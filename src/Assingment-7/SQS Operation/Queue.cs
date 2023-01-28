using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS_Operation
{
    public class Queue
    {
        public BasicAWSCredentials Creadential(string acccesskey, string secretKey)
        {
            BasicAWSCredentials basicAWSCredentials = new BasicAWSCredentials(acccesskey, secretKey);

            return basicAWSCredentials;
        }

        public async Task AddMassage(string acccesskey, string secretKey, string url, string massage)
        {
            var credential = Creadential(acccesskey, secretKey);

            using AmazonSQSClient client = new AmazonSQSClient(credential, Amazon.RegionEndpoint.APSouth1);

            var sendMessageRequest = new SendMessageRequest
            {
                DelaySeconds = 10,
                MessageBody = massage,
                QueueUrl = url
            };

            var response = await client.SendMessageAsync(sendMessageRequest);
            Console.WriteLine("Sent a message with id : {0}", response.MessageId);

        }

        public async Task Receivemassage(string acccesskey, string secretKey, string url)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonSQSClient client = new AmazonSQSClient(credential, Amazon.RegionEndpoint.APSouth1);

            var receiveMessageRequest = new ReceiveMessageRequest
            {
                AttributeNames = { "SentTimestamp" },
                MaxNumberOfMessages = 10,
                MessageAttributeNames = { "All" },
                QueueUrl = url,
                VisibilityTimeout = 0,
                WaitTimeSeconds = 0
            };

            var receiveMessageResponse = await client.ReceiveMessageAsync(receiveMessageRequest);

            foreach (var item in receiveMessageResponse.Messages)
            {
                Console.WriteLine(item.Body);
            }

            Console.WriteLine("\nNow I am  deleting this read Massage...");

            foreach (var item in receiveMessageResponse.Messages)
            {
                var deleteMessageRequest = new DeleteMessageRequest
                {
                    QueueUrl = url,
                    ReceiptHandle = item.ReceiptHandle
                };

                await client.DeleteMessageAsync(deleteMessageRequest);
            }

            Console.WriteLine(" \n Massage Deleted Successfully");
        }
    }
}

