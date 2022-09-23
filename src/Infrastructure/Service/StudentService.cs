using Infrastructure.BusinessObject;
using Infrastructure.Entities;
using Infrastructure.Unitofwork;

namespace Infrastructure.Service
{
    public class StudentService : IStudentService
    {
        private IApplicationUnitofWork _work;
        public StudentService(IApplicationUnitofWork work)
        {
            _work = work;
        }
       
        public void Take_Responsibility_For_CreateStudent(BStudent bstudent)
        {
            bstudent.anyLogic();

            Student student = new Student();
            student.Name = bstudent.BName;
            student.Email = bstudent.BEmail;
            student.Address = bstudent.BAddress;
            student.DateTime = bstudent.BDateTime;
            student.CGPA = bstudent.BCGPA;

            _work.studentRepository.Add(student);
            _work.Save();
           // _work.Dispose();

        }
        public IEnumerable<Student> getStudentLis()
        {
           IEnumerable<Student> students= _work.studentRepository.getAll();
           return students;
        }
    }
}
