using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class CovidChecker
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you have any travel history Yes:No");
            string ans = Console.ReadLine();
            if (ans == "yes" | ans == "YES")
            {
                Console.WriteLine("Do you have temperature? Yes:No");
                string ans1 = Console.ReadLine();
                if (ans1 == "yes" | ans1 == "YES")
                { 
                    Console.WriteLine("Do you have Cough or sneez Yes:No");
                    string ans2 = Console.ReadLine();
                    if (ans2 == "yes" | ans2 == "YES")
                    { 
                        Console.WriteLine("Take a SWAB TEST");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine Yourself and take Fever medicines");
                    }
                }
                else
                {
                    Console.WriteLine("Home Qurantine for 28 Days");
                }
            }
            else
            {
                Console.WriteLine("Not COVID-19");
            }
        }
    }
}
