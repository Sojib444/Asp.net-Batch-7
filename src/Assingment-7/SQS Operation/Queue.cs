using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS_Operation
{
    public class Queue
    {
        private ReceiveMessageResponse? readMassage { get; set; }
        private BasicAWSCredentials Creadential(string acccesskey, string secretKey)
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
            readMassage = receiveMessageResponse;

            foreach (var item in receiveMessageResponse.Messages)
            {
                Console.WriteLine(item.Body);
            } 
        }

        public async Task DeleteReadMassage(string acccesskey, string secretKey, string url)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonSQSClient client = new AmazonSQSClient(credential, Amazon.RegionEndpoint.APSouth1);

            if (readMassage.Messages.Count > 0)
            {
                foreach (var message in readMassage.Messages)
                {
                    var deleteMessageRequest = new DeleteMessageRequest
                    {
                        QueueUrl = url,
                        ReceiptHandle = message.ReceiptHandle
                    };

                    await client.DeleteMessageAsync(deleteMessageRequest);
                }
            }

        }
    }
}

