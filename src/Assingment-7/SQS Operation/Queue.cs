using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using System.Net;

namespace SQS_Operation
{
    public class Queue
    {

        public BasicAWSCredentials Creadential(string acccesskey, string secretKey)
        {
            BasicAWSCredentials basicAWSCredentials = new BasicAWSCredentials(acccesskey, secretKey);

            return basicAWSCredentials;
        }

        public async  Task AddMassage(string acccesskey, string secretKey, string url, String massage)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonSQSClient client = new AmazonSQSClient(credential, Amazon.RegionEndpoint.APSouth1);

            var sendMessageRequest = new SendMessageRequest
            {
                DelaySeconds = 10,
                MessageBody = massage,
                QueueUrl = url
            };

            var response = await client.SendMessageAsync(sendMessageRequest);
            Console.WriteLine("Sent a message with id : {0}", response.MessageId);

        }


        public async Task CreateQueueExample(string acccesskey, string secretKey)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonSQSClient client = new AmazonSQSClient(credential,Amazon.RegionEndpoint.APSouth1);

            var request = new CreateQueueRequest
            {
                QueueName = "SQS_QUEUE",
                Attributes = new Dictionary<string, string>
                {
                    { "DelaySeconds", "60"},
                    { "MessageRetentionPeriod", "86400"}
                }
            };


            var response = await client.CreateQueueAsync(request);
            Console.WriteLine("Created a queue with URL : {0}", response.QueueUrl);
        }
    }
}
