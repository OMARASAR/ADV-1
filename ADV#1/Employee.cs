using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal class Employee : IComparable<Employee>, IEquatable<Employee>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return age.CompareTo(E.age);
        //}

        public int CompareTo(Employee? other)
        {
            if (other is not null) return 1;
            
            return age.CompareTo(other.age);
        }

        public override string ToString()
        {
            return $"Id:{id} , name:{name} , age:{age}, salary:{salary}";
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return this == E;
        //}

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }

        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return left.id != right.id || left.name != right.name || left.age != right.age || left.salary != right.salary;

        //}
    }
}
