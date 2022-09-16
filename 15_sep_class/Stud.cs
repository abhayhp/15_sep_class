using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_sep_class
{
    public class Stud
    {
        private int rollno;
        private string name;
        private double per;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        } 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Per
        {
            get { return per; }
            set { per = value; }
        }
    }
}
