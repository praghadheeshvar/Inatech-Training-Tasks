using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("{0}*{1}={2}",num,i,num*i);
            }
        }
    }
}
