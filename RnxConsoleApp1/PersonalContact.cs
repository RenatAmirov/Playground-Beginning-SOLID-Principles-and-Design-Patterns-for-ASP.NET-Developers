using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxConsoleApp1
{
    public class PersonalContact : Contact
    {
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public override string GetDetails()
        {
            return FirstName + " " + LastName + " (" + BirthDate.ToString("dd-MMM-yyyy") + ")";
        }
    }
}
