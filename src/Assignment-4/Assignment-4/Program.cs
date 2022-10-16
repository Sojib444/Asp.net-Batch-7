// See https://aka.ms/new-console-template for more information

using Assignment_4;
using Assignment_4.Entity;
using Assignment_4.Model;
using Assignment_4.Object;

Course course = new Course();
course.Id = 31;
course.Title = "C++";
course.Topics = new List<Topic>()
{
        new Topic{Id=11,Title="Delegates and Event", Description="Fine",CourseId=31},
        new Topic{Id=12,Title="Delegates and Event", Description="Fine",CourseId=31},
        new Topic{Id=13,Title="Delegates and Event", Description="Fine",CourseId=31}
};
course.Teacher = new Instructor()
{
    Name = "jajal uddin",
    Email = "jajaj@gmail.com",
    CourseId = 31,
    Id = 21,
    PermanentAddress = new Address { Id = 7, City = "Pabna", Country = "Bangladesh", Street = "4343", IntructorId = 21 },
    PresentAddress = new Address { Id = 8, City = "Pabna", Country = "Bangladesh", Street = "4343", IntructorId = 21 },
    PhoneNumbers=new List<Phone>() { new Phone() {Id=6, Number="4343",CountryCode="88",Extension="+",TeacherId=21},
                                    new Phone() {Id=7, Number="4343",CountryCode="88",Extension="+",TeacherId=21}}
};
course.Topics = new List<Topic>() { new Topic() { Id=8,Title="It's very Fine",Description="googd",CourseId=31},
                        new Topic() { Id=9,Title="It's very Fine",Description="googd",CourseId=31}};
course.Tests = new List<AdmissionTest>() { new AdmissionTest(){ Id=7,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100,CourseId=31},
                new AdmissionTest(){ Id=8,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100,CourseId=31}};

course.Fees = 1232.64;

AdmissionTest admissionTest = new AdmissionTest();
admissionTest.StartDateTime = DateTime.Now;
admissionTest.EndDateTime = DateTime.Now.AddDays(10);
admissionTest.TestFees = 20;
admissionTest.Id = 1;
admissionTest.CourseId = 15;

Topic topic = new Topic();
topic.Id = 20;
topic.Title = "fsdfsd";
topic.Description = "ffsdgsdfd";
topic.CourseId= 30;


MyORM<int, AdmissionTest> type = new MyORM<int, AdmissionTest>();
type.Insert(admissionTest);

//string str = "Sojib,";
//Console.WriteLine(str.Length);
//string p=str.Remove(str.Length-1,1);
//Console.WriteLine(str.Length);
//Console.WriteLine(p);

