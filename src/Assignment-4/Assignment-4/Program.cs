// See https://aka.ms/new-console-template for more information

using Assignment_4;
using Assignment_4.Entity;
using Assignment_4.Model;
using Assignment_4.Object;

Course course = new Course();
course.Id = 1;
course.Title = "C++";
course.Topics = new List<Topic>()
{
        new Topic{Id=1,Title="Delegates and Event", Description="Fine",CourseId=1},
        new Topic{Id=2,Title="Delegates and Event", Description="Fine",CourseId=1},
        new Topic{Id=3,Title="Delegates and Event", Description="Fine",CourseId=1}
};
course.Teacher = new Instructor()
{
    Name = "jajal uddin",
    Email = "jajaj@gmail.com",
    CourseId = 1,
    Id = 1,
    PermanentAddress = new Address { Id = 1, City = "Pabna", Country = "Bangladesh", Street = "4343", IntructorId = 1 },
    PresentAddress = new Address { Id = 2, City = "Pabna", Country = "Bangladesh", Street = "4343", IntructorId = 1 },
    PhoneNumbers=new List<Phone>() { new Phone() {Id=6, Number="4343",CountryCode="88",Extension="+",TeacherId=1},
                                    new Phone() {Id=7, Number="4343",CountryCode="88",Extension="+",TeacherId=1}}
};
course.Topics = new List<Topic>() { new Topic() { Id=1,Title="It's very Fine",Description="googd",CourseId=1,
         Sessions=new List<Session>(){
         new Session(){Id=1,LearningObjective="very good",DurationInHour=2,TopicId=1}
         } },
        new Topic() { Id=2,Title="It's very Fine",Description="googd",CourseId=1,
        Sessions=new List<Session>(){
         new Session(){Id=3,LearningObjective="very good",DurationInHour=2,TopicId=1}
         }}
        };
//course.Tests = new List<AdmissionTest>() { new AdmissionTest(){ Id=1,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100,CourseId=1},
//                new AdmissionTest(){ Id=1,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100,CourseId=1}};

course.Fees = 10000;

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


MyORM<int, Course> type = new MyORM<int, Course>();
//type.Insert(course);

type.GetAll();
//type.GetById(2);

//string str = "Sojib,";
//Console.WriteLine(str.Length);
//string p=str.Remove(str.Length-1,1);
//Console.WriteLine(str.Length);
//Console.WriteLine(p);

