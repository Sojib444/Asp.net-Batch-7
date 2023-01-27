

using SQS_Operation;


string? accessKey = "AKIAUPSWFFBGHYUUXMZD";
string? secrectkey = "jDQN6v/QHkXZm/xdUMWp2eAeWLE+U1UNfE172ueM";
string queueURl = "https://sqs.ap-south-1.amazonaws.com/308344596556/SQS_QUEUE_NAME";
string massage = "Hi this Sojib";

Queue queue= new Queue();
await queue.AddMassage(accessKey,secrectkey, queueURl, massage);

//var result =queue.GetMessage(accessKey, secrectkey,queueURl);
//Console.WriteLine(result.IsCompletedSuccessfully);

//await queue.CreateQueueExample(accessKey, secrectkey);