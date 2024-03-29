﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxConsoleApp1
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public virtual string GetDetails()
        {
            return FirstName + " " + LastName + " (" + EmailAddress + "," + PhoneNo + ")";
        }
    }
}
