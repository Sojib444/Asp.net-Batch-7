using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Course : IGuid<int>
    {
    public string Title { get; set; }

    public int Id
    {
        get; set;
    }
}
