using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxConsoleApp1
{
    public class ProfessionalContact : Contact
    {
        public string Service { get; set; }
        public string Address { get; set; }
        public string Timing { get; set; }
        public override string GetDetails()
        {
            return FirstName + " " + LastName + " (" + Service + ", " + Timing + ")";
        }
    }
}
