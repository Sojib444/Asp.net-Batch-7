using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;

namespace DynamoDb_Operation
{
    public class DynamoDb
    {
        private BasicAWSCredentials Creadential(string acccesskey, string secretKey)
        {
            BasicAWSCredentials basicAWSCredentials = new BasicAWSCredentials(acccesskey, secretKey);

            return basicAWSCredentials;
        }

        public async Task InsertIntoTable(string acccesskey, string secretKey, string tableName)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonDynamoDBClient client = new AmazonDynamoDBClient(credential, Amazon.RegionEndpoint.APSouth1);

            PutItemRequest request = new PutItemRequest
            {
                TableName = tableName,
                Item = new Dictionary<string, AttributeValue>
                        {
                            { "Id", new AttributeValue { N = "10" } },
                            { "Name", new AttributeValue { S = "Kaium" } },
                            { "Home", new AttributeValue { S = "Rajshahi" } },
                            { "College", new AttributeValue { S = "Rajshahi new govt Degree College" } },
                            { "University", new AttributeValue { S = "University of Rajshahi" } }
                        }
            };

            PutItemResponse response = await client.PutItemAsync(request);

            Console.WriteLine("Ststus Code : " + response.HttpStatusCode + $"; Insert data into {tableName}");
        }

        public async Task GetItm(string acccesskey, string secretKey, string tableName, int range)
        {

            var credential = Creadential(acccesskey, secretKey);

            AmazonDynamoDBClient client = new AmazonDynamoDBClient(credential, Amazon.RegionEndpoint.APSouth1);

            var request = new ScanRequest
            {
                TableName = tableName,
                Limit = range,
            };

            var response = await client.ScanAsync(request);

            var items = response.Items;

            foreach (var item in items)
            {
                foreach (var kvp in item)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.S}");
                }
            }

        }

        public async Task DeleteItem(string acccesskey, string secretKey, string tableName, int id)
        {
            var credential = Creadential(acccesskey, secretKey);

            AmazonDynamoDBClient client = new AmazonDynamoDBClient(credential, Amazon.RegionEndpoint.APSouth1);

            var key = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { N = Convert.ToString(id) } }
            };

            var request = new DeleteItemRequest
            {
                TableName = tableName,
                Key = key
            };

            var response = await client.DeleteItemAsync(request);

            Console.WriteLine($"Status for deleting item : {response.HttpStatusCode} ");
        }
    }
}
