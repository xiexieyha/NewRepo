using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Person
    {
        
        public int age { get; set; }
        public abstract decimal salary { get; set; }
        public  List<string>? Address { get; set; }
    }

       

    class Student : Person
    {
        public List<string>? Course { get; set; }
        public double gpa { get; set; }
        public override decimal salary { get; set; } 
        public string? grade { get; set; }
    }

    class Instructor : Person
    {
        public override decimal salary { get; set; }
        public int deptID { get; set; }

    }

    public interface IDepartment<T> where T : class
    {
         void Budget()
    }
}