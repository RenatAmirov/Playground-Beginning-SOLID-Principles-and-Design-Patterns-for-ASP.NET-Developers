using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessContact c1 = new BusinessContact();
            c1.FirstName = "Nancy";
            c1.LastName = "Davolio";
            c1.EmailAddress = "nancy@localhost";
            c1.PhoneNo = "(206) 555-9857";
            c1.CompanyName = "Northwind Traders Inc.";
            c1.Designation = "Sales Representative";

            ProfessionalContact c2 = new ProfessionalContact();
            c2.FirstName = "Andrew";
            c2.LastName = "Fuller";
            c2.EmailAddress = "andrew@localhost";
            c2.PhoneNo = "(206) 555-9482";
            c2.Service = "Doctor";
            c2.Address = "908 W. Capital Way, Tacoma, USA";
            c2.Timing = "10 AM to 6 PM";

            PersonalContact c3 = new PersonalContact();
            c3.FirstName = "Janet";
            c3.LastName = "Leverling";
            c3.EmailAddress = "janet@localhost";
            c3.PhoneNo = "(206) 555-3412";
            c3.BirthDate = new DateTime(1971, 3, 20);

            ShowDetails(c1);
            ShowDetails(c2);
            ShowDetails(c3);
        }
        public static void ShowDetails(Contact c)
        {
            string details = c.GetDetails();
            Console.WriteLine(details);
            Console.ReadLine();
        }
    }
}
