using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnxWebApp1.Model
{
    public class Contact
    {
        private string fname;
        private string lname;
        private string emailaddr;
        private string phoneno;
        private string addr;
        private string cname;
        private byte[] photo;
        private DateTime dob;
        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string EmailAddress
        {
            get { return emailaddr; }
            set
            {
                if (emailaddr.Contains("@") && emailaddr.Contains("."))
                {
                    emailaddr = value;
                }
                else
                {
                    throw new Exception("Invalid Email address!");
                }
            }
        }
        public string PhoneNo
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        public string Address
        {
            get { return addr; }
            set { addr = value; }
        }
        public string CompanyName
        {
            get { return cname; }
            set { cname = value; }
        }
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public DateTime BirthDate
        {
            get { return dob; }
            set
            {
                if ((DateTime.Today.Year - value.Year) > 18)
                {
                    dob = value;
                }
                else
                {
                    throw new Exception("Invalid birth date. Age must be greater than 18.");
                }
            }
        }
    }
}