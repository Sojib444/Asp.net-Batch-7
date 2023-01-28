using SQS_Operation;

string? accessKey = "";
string? secrectkey = "";
string queueURl = "https://sqs.ap-south-1.amazonaws.com/308344596556/SQS_QUEUE_NAME";
string massage = $"Hi this Sojib.I send a have to send a massage in queue at {DateTime.Now}";

Queue queue= new Queue();
//await queue.AddMassage(accessKey,secrectkey, queueURl, massage);

await queue.Receivemassage(accessKey, secrectkey, queueURl);
await queue.DeleteReadMassage(accessKey, secrectkey, queueURl);



