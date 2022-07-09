using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxConsoleApp1
{
    public class BusinessContact : Contact
    {
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public override string GetDetails()
        {
            return FirstName + " " + LastName + " (" + Designation + ", " + CompanyName + ")";
        }
    }
}
