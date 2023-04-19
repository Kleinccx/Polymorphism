using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pr;

            pr = new Student("John", "Doe", 20, "1234", "Computer Science");
       
            Console.WriteLine(pr.DisplayInfo());

            pr = new Employee("Jane", "Smith", 30, "5678", 50000);
      
            Console.WriteLine(pr.DisplayInfo());
        }
    }
}