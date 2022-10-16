// See https://aka.ms/new-console-template for more information

using Assignment_4;
using Assignment_4.Entity;
using Assignment_4.Model;

Course course = new Course();
course.Id = 19;
course.Title = "Python";
//course.Topics = new List<Topic>()
//{
//        new Topic{Id=1,Title="Delegates and Event", Description="Fine",CourseId=4},
//        new Topic{Id=2,Title="Delegates and Event", Description="Fine",CourseId=4},
//        new Topic{Id=3,Title="Delegates and Event", Description="Fine",CourseId=4}
//};
course.Teacher = new Instructor()
{
    Name = "jajal uddin",
    Email = "jajaj@gmail.com",
    CourseId = 19,
    Id = 11
};
course.Fees = 1232.64;

MyORM<int, Course> type = new MyORM<int, Course>();
type.Insert(course);

//string str = "Sojib,";
//Console.WriteLine(str.Length);
//string p=str.Remove(str.Length-1,1);
//Console.WriteLine(str.Length);
//Console.WriteLine(p);

