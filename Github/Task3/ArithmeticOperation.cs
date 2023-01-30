using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class ArithmeticOne
    {
        int Result;
        public int Add(int num1, int num2)
        {
            Result = num1 + num2;
            return Result;
        }
        public int Subtract(int num1, int num2)
        {
            int Result = num1 - num2;
            return Result;
        }
    }
    class ArithmeticTwo : ArithmeticOne
    {
        int Result;
        public int Multiply(int num1, int num2)
        {
            Result = num1 * num2;
            return Result;
        }
        public int Divide(int num1, int num2)
        {
            Result = num1 / num2;
            return Result;
        }
    }
    class ArithmeticOperation
    {
        public static void Main(string[] args)
        {
            ArithmeticTwo atobj=new ArithmeticTwo();
            Console.WriteLine("Enter 2 numbers:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Choice:" +
                "1 for addition,2 for subtraction,3 for multiplication,4 for division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int addresult = atobj.Add(n1, n2);
                    Console.WriteLine("Addition of {0} and {1} is:{2}", n1, n2, addresult);
                    break;

                case 2:
                    int subresult = atobj.Subtract(n1, n2);
                    Console.WriteLine("Subtraction of {0} and {1} is:{2}", n1, n2, subresult);
                    break;

                case 3:
                    int mulresult = atobj.Multiply(n1, n2);
                    Console.WriteLine("Multiplication of {0} and {1} is:{2}", n1, n2, mulresult);
                    break;

                case 4:
                    int divresult = atobj.Divide(n1, n2);
                    Console.WriteLine("Division of {0} and {1} is:{2}", n1, n2, divresult);
                    break;
                
                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
        }
    }
}
