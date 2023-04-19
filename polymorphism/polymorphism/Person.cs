using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal abstract class Person
    {
        public string fname;
        public string lname;
        public int age;

        public Person()
        {
            // Default constructor
        }

        public Person(string fname, string lname, int age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }

        public abstract string DisplayInfo();
    }
}


