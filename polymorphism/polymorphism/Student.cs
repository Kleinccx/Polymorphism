    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace polymorphism
    {
        internal class Student : Person
        {
            public string StudentID;
            public string Course;

            public Student() : base()
            {
                // Default constructor
            }

            public Student(string fname, string lname, int age, string studentID, string course)
                : base(fname, lname, age)
            {
                StudentID = studentID;
                Course = course;
            }

            public override string ToString()
            {
                return $"{fname} {lname} {age} years old, Student ID: {StudentID}, Course: {Course}";
            }

            public override string DisplayInfo()
            {
                return $"First name: {fname} \nLast name: {lname} \nAge: {age} \nStudent ID: {StudentID} \nCourse: {Course}\n";
            }
        }
    }
