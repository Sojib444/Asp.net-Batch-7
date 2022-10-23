using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Object
{
    public class Session:IGuid<int>
    {
        public int Id { get; set; }
        public int DurationInHour { get; set; }
        public string LearningObjective { get; set; }
    }
}
