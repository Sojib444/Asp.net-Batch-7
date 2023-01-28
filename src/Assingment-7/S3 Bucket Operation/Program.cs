
using S3_Bucket_Operation;

string? accessKey = "";
string? secrectkey = "";

string? bucketName = "devtract";
string? filePath = @"E:\Sojib.txt";

string? objectName = "Sojib.txt";

BucketOpration opration = new BucketOpration();

await opration.UploadObject(accessKey, secrectkey, bucketName, filePath);
opration.DownloadObject(accessKey, secrectkey, bucketName, objectName);
await opration.DeleteObject(accessKey, secrectkey, bucketName, objectName);