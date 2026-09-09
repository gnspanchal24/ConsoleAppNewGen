using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNewGen
{
    public class Employee
    {
        public void GetInfo()
        {
            Console.WriteLine("Employee Information");
        }

        public void GetInfo(string name)
        {
            Console.WriteLine($"Employee Name: {name}");
        }

        public void GetInfo(string name, int age)
        {
            Console.WriteLine($"Employee Name: {name}, Age: {age}");
        }
    }
}
