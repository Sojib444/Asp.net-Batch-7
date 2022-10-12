using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public interface IGuid<G>
    {
        G Id { get; set; }
    }
}
