using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class PersonDetail
    {
        public string Name;
        public int Age;

        public PersonDetail()
        {
            Name = "Praggi";
            Age = 21;
        }
        public PersonDetail(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    internal class Person
    {
        public static void Main(string[] args)
        {
            PersonDetail pobj1 = new PersonDetail();
            Console.WriteLine("Name: " + pobj1.Name + " Age: " + pobj1.Age);
            PersonDetail pobj2 = new PersonDetail("Inatech", 30);
            Console.WriteLine("Name: " + pobj2.Name + " Age: " + pobj2.Age);
        }
    }
}
