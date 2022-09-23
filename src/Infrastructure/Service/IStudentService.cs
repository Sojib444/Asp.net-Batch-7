using Infrastructure.BusinessObject;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IStudentService
    {
        public void Take_Responsibility_For_CreateStudent(BStudent bStudent);
        public IEnumerable<Student> getStudentLis();



    }
}
