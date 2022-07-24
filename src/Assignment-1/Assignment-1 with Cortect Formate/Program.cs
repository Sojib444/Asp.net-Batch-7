using Assignment;
using System.Reflection;

var adderss = new Address()
{
    Street = "Kazi Road",
    City = "Bagura",
    Country = "Bangladesh"
};

var sessions = new List<Session>()
{
    new Session()  { DurationInHour = 9, LearningObjective = "item 1"},
    new Session()  {DurationInHour = 5, LearningObjective = "item 2"}
};

var topic = new Topic()
{
    Title = "Java",
    Description = "Basic java topic",
    Sessions = sessions
};

var instructor = new Instructor
{
    Name = "Tareq",
    Email = "tareq@gmail.com",
    PresentAddress = adderss,
    PermanentAddress = adderss,
    PhoneNumbers = new List<Phone> { new Phone { CountryCode ="gsgsg", Extension="ghd", Number= "jh" },
                                     new Phone { CountryCode ="fsg", Extension="rge", Number= "gh" }
                                    }
};



var admissionTest = new AdmissionTest()
{
    StartDateTime = DateTime.Now,
    EndDateTime = DateTime.Now,
    TestFees = 323.342
};

var course = new Course
{
    Topics = new List<Topic> { topic, topic },
    Tests = null
};

string Json = JsonFormatter.Convert(course);

for (int i = Json.Length - 1; i >= 0; i--)
{
    if ((Json[i] >= '0' && Json[i] <= '9') || (Json[i] >= 'a' && Json[i] <= 'z') || (Json[i] >= 'A' && Json[i] <= 'Z') || Json[i]==']' ||Json[i]=='}' ||Json[i]=='"')
    {
        if (i + 1 < Json.Length)
        {
            if (Json[i + 1] == ',')
            {
                string bson = Json.Remove(i + 1, 1);
                Json = bson;
                break;
                
            }

            break;

        }

    }
}
Console.WriteLine(Json);









