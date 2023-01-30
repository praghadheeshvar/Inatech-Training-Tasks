using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TVPackage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Package A comtains 1)South special 2)Children's Club 3)Movies");
            Console.WriteLine("Package B contains 1)News 2)Movies 3)Regional-2");
            Console.WriteLine("Package C contains Discovery,National,History");
            Console.WriteLine("Enter Choice:");
            string ch=Console.ReadLine();
            switch (ch)
            {
                case "A":
                    Console.WriteLine("Rate:250");
                    break;
                case "B":
                    Console.WriteLine("Rate:450");
                    break;
                case "C":
                    Console.WriteLine("Rate:350");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
