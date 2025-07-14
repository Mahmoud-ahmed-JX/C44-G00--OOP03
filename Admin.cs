using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_amnt3
{
    internal class Admin : Person
    {
        private string role;

        public string Role
        {
            get { return role; }
            set
            {
                if (value == "Coordinator" || value == "Secretary")
                {
                    role = value;
                }
                else
                {
                    Console.WriteLine("Invalid Role");
                }
            }
        }

        public Admin(string _firstName, string _lastName, int _age, string _role) : base(_firstName, _lastName, _age)
        {
            role = _role;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Full Name: {GetFirstName()} {GetLastName()} ,Age: {GetAge()} ,Role: {role}");
        }
    }
}
