using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFramework
{
    public interface IApplicationDbContex
    {
         DbSet<Book>? books { get; set; }
         DbSet<Reader>? readers { get; set; }
    }
}
