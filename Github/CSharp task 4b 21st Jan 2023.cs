using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Arithmetic
    {
        public abstract int add(int num1, int num2);
        public abstract int subtract(int num1, int num2);
        public abstract int multiply(int num1, int num2);
        public abstract int divide(int num1, int num2);

    }
    public class Calculator : Arithmetic
    {
        public override int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public override int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public override int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public override int divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    internal class ArithmeticOperations
    {
        public static void Main(string[] args)
        {
            int result;
            ArithmeticOperations aoobj = new ArithmeticOperations();
            Arithmetic arithmetic;
            int num1, num2;
            Console.WriteLine("enter 2 numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter choice:" +
                "1 for addition 2 for subtraction 3 for multiplication 4 for division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    arithmetic = new Calculator();
                    result = arithmetic.add(num1, num2);
                    Console.WriteLine("Addition of {0} and {1} is : {2}", num1, num2, result);
                    break;

                case 2:
                    arithmetic = new Calculator();
                    result = arithmetic.subtract(num1, num2);
                    Console.WriteLine("Subtraction of {0} and {1} is : {2}", num1, num2, result);
                    break;

                case 3:
                    arithmetic = new Calculator();
                    result = arithmetic.multiply(num1, num2);
                    Console.WriteLine("Multiplication of {0} and {1} is : {2}", num1, num2, result);
                    break;

                case 4:
                    arithmetic = new Calculator();
                    result = arithmetic.divide(num1, num2);
                    Console.WriteLine("Division of {0} and {1} is : {2}", num1, num2, result);
                    break;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
        }
    }
}

