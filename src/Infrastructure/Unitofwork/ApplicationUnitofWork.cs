using Infrastructure.EntityFramework;
using Infrastructure.EntityRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Unitofwork
{
    public class ApplicationUnitofWork :UnitOfWork, IApplicationUnitofWork
    {

        public IStudentRepository studentRepository { get; }
        public ApplicationUnitofWork(IApplicationDbContex dbContext, 
            IStudentRepository studentRepository) : base((DbContext)dbContext)
        {
            this.studentRepository = studentRepository;
        }


    }
}
