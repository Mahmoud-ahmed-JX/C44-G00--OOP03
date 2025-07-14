using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_amnt3
{
    internal class Teacher:Person
    {
        public string Subject { get; set; }

        public Teacher(string _firstName,string _lastName,int _age,string _subject):base(_firstName,_lastName,_age)
        {
            Subject = _subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Full Name: {GetFirstName()} {GetLastName()} ,Age: {GetAge()} ,Subject: {Subject}");
        }
    }
}
