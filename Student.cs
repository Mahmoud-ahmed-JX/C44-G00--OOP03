using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_amnt3
{
    internal class Student:Person
    {
        public string GradeLevel { get; set; }

        public Student(string fname,string lname,int age,string _gradeLevel):base(fname,lname,age)
        {
            GradeLevel = _gradeLevel;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Full Name: {GetFirstName()} {GetLastName()} ,Age: {GetAge()} ,Grade Level: {GradeLevel}");

        }
    }
}
