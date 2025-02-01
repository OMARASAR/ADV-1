using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal class Employee : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee E = (Employee)obj;
            return age.CompareTo(E.age);
        }

        public override string ToString()
        {
            return $"Id:{id} , name:{name} , age:{age}, salary:{salary}";
        }








    }
}
