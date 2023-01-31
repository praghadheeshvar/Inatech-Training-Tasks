using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class EmployeeDetails
    {
        double salary, bonus;

        public void Sales(double sal)
        {
            this.salary = sal;
            bonus = salary * 20 / 100;
            salary = salary + bonus;
            double total = salary + bonus;
            Console.WriteLine("Salary:" + salary + " Bonus:" + bonus + " Total:" + total);
        }
        public void Production(double sal)
        {
            this.salary = sal;
            bonus = salary * 10 / 100;
            double total = salary + bonus;
            Console.WriteLine("Salary:" + salary + " Bonus:" + bonus + " Total:" + total);
        }
    }
    internal class Employee
    {
        public static void Main(string[] args)
        {
            EmployeeDetails emobj = new EmployeeDetails();
            Console.WriteLine("Enter employee name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Employee id:");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender:");
            string Gender = Console.ReadLine();

            Console.WriteLine("Enter the years of experience:");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the department:" +
                "1.Sales 2.Production");
            int dept = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary:");
            int s = Convert.ToInt32(Console.ReadLine());
            switch (dept)
            {
                case 1:
                    Console.WriteLine("Name:" + Name + " EmployeeID:" + empid + " Gender:" + Gender + " Years of Experience:" + experience);
                    emobj.Sales(s);
                    break;

                case 2:
                    Console.WriteLine("Name:" + Name + " EmployeeID:" + empid + " Gender:" + Gender + " Years of Experience:" + experience);
                    emobj.Production(s);
                    break;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
        }
    }
}
