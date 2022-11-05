using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt8
{
    internal interface Ihuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Pol { get; set; }
        string Dolzhnost { get; set; }
        string GetInfo();
    }
}
