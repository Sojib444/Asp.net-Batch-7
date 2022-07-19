using Assignment;
using System.Reflection;

List<Phone> phones = new List<Phone>();
phones.Add(new Phone() { CountryCode = "323", Extension = "323", Number = "2323" });
phones.Add(new Phone() { CountryCode = "23", Extension = "43", Number = "534" });
phones.Add(new Phone() { CountryCode = "7676", Extension = "2323", Number = "7868" });


List<Session> sessions = new List<Session>();
sessions.Add(new Session() { DurationInHour = 144, LearningObjective = "Very Important" });
sessions.Add(new Session() { DurationInHour = 344, LearningObjective = "Marked as Bold" });
sessions.Add(new Session() { DurationInHour = 5, LearningObjective = "Marked as Red" });

List<Session> sessions2 = new List<Session>()
        { new Session() { DurationInHour = 2, LearningObjective = "Have a nice Day" },
        new Session() { DurationInHour = 32, LearningObjective = "Devskill Team" } ,
        new Session() { DurationInHour = 5, LearningObjective = "Read Properly" }
       };

List<Topic> topics = new List<Topic>();
topics.Add(new Topic() { Description = "Awesome", Title = "Linq", Sessions = sessions });
topics.Add(new Topic() { Description = "Fine", Title = "Reflection", Sessions = sessions2 });

List<AdmissionTest> admissionTests = new List<AdmissionTest>() {
         new AdmissionTest()
         { EndDateTime=new DateTime(2022,3,1),StartDateTime=new DateTime(2022-2-1),TestFees=100},
         new AdmissionTest()
         { EndDateTime=new DateTime(2023-2-1),StartDateTime=new DateTime(2023,4,5),TestFees=200}

      };

Address address = new Address();
address.Street = "3232";
address.City = "Dhaka";
address.Country = "Bangladesh";

Address address1 = new Address() { City = "Idia", Country = "Mohadesh", Street = "w4343" };

Instructor instructor = new Instructor();
instructor.Name = "Md Jalal Udiin";
instructor.Email = "Jalal@gmail.com";
instructor.PresentAddress = address;
instructor.PhoneNumbers = phones;
instructor.PermanentAddress = address1;


Course course = new Course();
course.Title = "Asp.net batch-7";
course.Fees = 3000;
course.Array =new int[] {1,2,3,5,6};
course.Teacher = instructor;
course.Topics = topics;
course.Tests = admissionTests;



string Json=JsonFormatter.Convert(course);
Console.WriteLine(Json);







//Session addSession = new Session()
//{
//    DurationInHour = 10,
//    LearningObjective = "Very nice"
//};


//Instructor addInstructor = new Instructor()
//{
//    Email = "Jalal@gmail.com",
//    Name = "Jalal Udiin",
//    PermanentAddress = address,
//    PresentAddress = address1,
//    PhoneNumbers = phones
//};

//Phone addPone = new Phone()
//{
//    CountryCode = "89",
//    Extension = "017",
//    Number = "778553706"
//};

//AdmissionTest admission = new AdmissionTest()
//{
//    EndDateTime = new DateTime(22, 2, 1),
//    StartDateTime = new DateTime(23, 4, 5),
//    TestFees = 500
//};

//Topic addTopic = new Topic()
//{
//    Description = "Partial Class",
//    Sessions = sessions
//};