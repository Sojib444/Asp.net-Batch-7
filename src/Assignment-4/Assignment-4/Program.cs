// See https://aka.ms/new-console-template for more information

using Assignment_4;
using Assignment_4.Entity;
using Assignment_4.Model;
using Assignment_4.Object;

Course course = new Course();
course.Id = 1;
course.Title = "Javascript";
course.Teacher = new Instructor()
{
    Name = "jajal uddin",
    Email = "jajaj@gmail.com",
    Id = 1,
    PermanentAddress = new Address { Id = 1, City = "Pabna", Country = "Bangladesh", Street = "4343" },
    PresentAddress = new Address { Id = 2, City = "Pabna", Country = "Bangladesh", Street = "4343" },
    PhoneNumbers=new List<Phone>() { new Phone() {Id=1, Number="4343",CountryCode="88",Extension="+"},
                                    new Phone() {Id=2, Number="4343",CountryCode="88",Extension="+"}}
};
course.Topics = new List<Topic>() { new Topic() { Id=1,Title="Its very Fine",Description="googd",
         Sessions=new List<Session>(){
         new Session(){Id=1,LearningObjective="very good",DurationInHour=2}
         } },
        new Topic() { Id=2,Title="Its very Fine",Description="googd",
        Sessions=new List<Session>(){
         new Session(){Id=2,LearningObjective="HI HI HI",DurationInHour=2}
         }}
        };
course.Tests = new List<AdmissionTest>() { new AdmissionTest(){ Id=1,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100},
             new AdmissionTest(){ Id=2,StartDateTime=DateTime.Now,EndDateTime=DateTime.Now.AddDays(10),TestFees=100}};

course.Fees = 2000;





MyORM<int, Course> type = new MyORM<int, Course>();


