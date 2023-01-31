using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DisplayName
    {
        public static void Main(string[] args)
        {
            string Name;
            int age;
            Console.WriteLine("Enter name and age:");
            Name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
