using Assignment_4.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Model
{
    public class Instructor:IGuid<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Address? PresentAddress { get; set; }
        public Address? PermanentAddress { get; set; }
        public List<Phone>? PhoneNumbers { get; set; }

    }
}
