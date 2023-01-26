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

        public void AddMassage(string acccesskey, string secretKey,string url,String Massage)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonSQSClient client = new AmazonSQSClient(credential, Amazon.RegionEndpoint.APSouth1);
            var  massageRespons =  client.SendMessageAsync(url, Massage);

            Console.WriteLine($"Massage add to the {url}");
            Console.WriteLine($"HttpStatusCode: {massageRespons.Status}");

        }
    }
}
