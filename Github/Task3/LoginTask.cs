using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Task8b
    {
        string email = "praggi831@gmail.com";
        string pass = "Praggi@123";
        int pin = 8301;
        int pin_num = 8301;
        string Mid = "Praggi";
        long mb = 1234567890;
        public void validate(string mail, string pwd)
        {
            this.email = mail;
            this.pass = pwd;
            if (mail == email && pwd == pass)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(string Mship, int Pin)
        {
            this.Mid = Mship;
            this.pin = Pin;
            if (Mship == Mid && Pin == pin)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(long Mobile, int pnum)
        {
            this.mb = Mobile;
            this.pin_num = pnum;
            if (Mobile == mb && pnum == pin_num)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        internal class LoginTask
        {
            public static void Main(string[] args)
            {
                Task8b obj = new Task8b();
                Console.WriteLine("Enter Login Credentials:");
                Console.Write("a.Login with Email id and password\t");
                Console.Write("b.Login with Membership id and pin\t");
                Console.WriteLine("c.Login with Mobile no and pin\t");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "a":
                        Console.WriteLine("Enter Email id:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string pass = Console.ReadLine();
                        obj.validate(email, pass);
                        break;

                    case "b":
                        Console.WriteLine("Enter Membership id:");
                        string Mid = Console.ReadLine();
                        Console.WriteLine("Enter pin:");
                        int pin = Convert.ToInt32(Console.ReadLine());
                        obj.validate(Mid, pin);
                        break;

                    case "c":
                        Console.WriteLine("Enter mobile number:");
                        long mb = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter pin");
                        int Pin = Convert.ToInt32(Console.ReadLine());
                        obj.validate(mb, Pin);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!!!");
                        break;
                }
            }
        }
    }
}