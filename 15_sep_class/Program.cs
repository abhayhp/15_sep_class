using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_sep_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stud s1 = new Stud();
            //s1.Rollno = 23;

            //Console.WriteLine(s1.Rollno);

            // object initializer syntax
            Stud s2 = new Stud { Name = "Abhay", Per = 80.0, Rollno = 4 };

            Console.WriteLine($" {s2.Name} {s2.Per} {s2.Rollno}");

            Emp emp1 = new Emp { Id = 2, Name = "abhay", Salary = 20000 };
            Console.WriteLine(emp1);

        }
    }
}
