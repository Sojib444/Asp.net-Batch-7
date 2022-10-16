using Assignment_4.Model;
using Assignment_4.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Entity
{
    public class Course : IGuid<int>
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public Instructor Teacher { get; set; }
        public List<Topic> Topics { get; set; }
        public double Fees { get; set; }
        public List<AdmissionTest> Tests { get; set; }

    }

}
