using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public string School { get; set; }
        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        public override void Info()
        {
            //base.Info();
            Console.WriteLine($"... and I am {GetType().Name}");
        }
    }
}
