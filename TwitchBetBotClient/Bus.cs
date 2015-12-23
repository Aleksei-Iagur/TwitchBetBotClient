using System;
using System.Configuration;
using Apache.NMS;
using Apache.NMS.Util;
using Newtonsoft.Json;

namespace TwitchBetBotClient
{
    public class Bus
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly double _ttl;

        public Bus()
        {
            var busAddress = ConfigurationManager.ConnectionStrings["service-bus"].ConnectionString;

            if (!double.TryParse(ConfigurationManager.AppSettings["ttl"], out _ttl))
            {
                _ttl = 5;
            }

            var uri = new Uri(busAddress);
            _connectionFactory = new NMSConnectionFactory(uri);
        }

        public void SendMessage(string queueName)
        {
            using (var connection = _connectionFactory.CreateConnection())
            using (var session = connection.CreateSession())
            {
                var destination = SessionUtil.GetDestination(session, "queue://" + queueName);

                using (var producer = session.CreateProducer(destination))
                {
                    producer.TimeToLive = TimeSpan.FromSeconds(_ttl);
                    connection.Start();

                    var request = session.CreateTextMessage(string.Empty);

                    producer.Send(request);
                }
            }
        }

        public void SendMessage<T>(string queueName, T message)
        {
            using (var connection = _connectionFactory.CreateConnection())
            using (var session = connection.CreateSession())
            {
                var destination = SessionUtil.GetDestination(session, "queue://" + queueName);

                using (var producer = session.CreateProducer(destination))
                {
                    producer.TimeToLive = TimeSpan.FromSeconds(_ttl);
                    connection.Start();

                    var request = session.CreateTextMessage(JsonConvert.SerializeObject(message));

                    producer.Send(request);
                }
            }
        }

        public T SendRequestReply<T>(string queueName, string message = "")
        {
            Console.WriteLine($"Sending request in {queueName}.");
            using (var connection = _connectionFactory.CreateConnection())
            using (var session = connection.CreateSession())
            {
                var destination = SessionUtil.GetDestination(session, "queue://" + queueName);
                var replyDestination = session.CreateTemporaryQueue();

                using (var producer = session.CreateProducer(destination))
                using (var replyConsumer = session.CreateConsumer(replyDestination))
                {
                    producer.TimeToLive = TimeSpan.FromSeconds(_ttl);
                    connection.Start();

                    var request = session.CreateTextMessage(message);
                    request.NMSReplyTo = replyDestination;
                    request.NMSCorrelationID = Guid.NewGuid().ToString();

                    producer.Send(request);

                    var objectMessage = replyConsumer.Receive() as ITextMessage;

                    if (objectMessage == null)
                    {
                        throw new NullReferenceException();
                    }

                    var response = objectMessage.Text.StartsWith("<")
                        ? JsonConvert.DeserializeObject<T>(objectMessage.ToObject().ToString())
                        : JsonConvert.DeserializeObject<T>(objectMessage.Text);

                    Console.WriteLine($"The answer on {queueName} was recieved.");
                    return response;
                }
            }
        }
    }
}