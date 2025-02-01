using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public override string ToString()
        {
            return $"Id:{id} , name:{name} , age:{age}, salary:{salary}";
        }








    }
}
