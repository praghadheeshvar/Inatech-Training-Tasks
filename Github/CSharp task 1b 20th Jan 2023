using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ElectricityBill
    {
        public static void Main(string[] args)
        {
            int units, amount;
            Console.WriteLine("Enter the number of units:");
            units=Convert.ToInt32(Console.ReadLine());
            if (units > 0 && units <= 200)
                amount = units * 2;
            else if (units >= 201 && units <= 350)
                amount = (units - 200) * 3 + 200 * 2;
            else if (units >= 351 && units <= 500)
                amount = (units - 350) * 5 + (200 * 2) + (150 * 3);
            else
                amount = (units - 500) * 7 + (200 * 2) + (150 * 3) + (150 * 5);
            Console.WriteLine("The bill amount is: {0}", amount);
        }
    }
}
