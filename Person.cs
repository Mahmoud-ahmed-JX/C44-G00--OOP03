using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_amnt3
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string GetFirstName() { return firstName; }

        public void SetFirstName(string firstName) { this.firstName = firstName; }
        
        public string GetLastName() { return lastName; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }

        public Person(string _firstName,string _lastName,int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName} ,Age: {age}");
        }
    }
}
