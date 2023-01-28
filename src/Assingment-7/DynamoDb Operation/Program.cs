
using DynamoDb_Operation;

string? accessKey = "";
string? secrectkey = "";
string tableName = "Sojib";


DynamoDb dynamo = new DynamoDb();

await dynamo.InsertIntoTable(accessKey,secrectkey,tableName);
await dynamo.GetItm(accessKey,secrectkey,tableName,10);
await dynamo.DeleteItem(accessKey,secrectkey,tableName,7);
