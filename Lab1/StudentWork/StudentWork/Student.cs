using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWork
{
    class Student
    {
        string firstName;
        string lastName;
        double gpa;

        public Student()
        {
            firstName = "firstName";
            lastName = "lastName";
            gpa = 0;
        }
        public Student(string firstName, string lastName, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return firstName + " " + lastName + " " + gpa;
        }
    }

}