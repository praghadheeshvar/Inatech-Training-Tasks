using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Membership
    {
        public abstract void Membershiptype();
    }
    public class GoldMembership:Membership
    {
        public override void Membershiptype()
        {
            Console.WriteLine("5 days accomodation at resort and 2 dinners on the house");
        }
    }
    public class SilverMembership:Membership
    {
        public override void Membershiptype()
        {
            Console.WriteLine("3 days accomodation at resort");
        }
    }
    public class PlatinumMembership:Membership
    {
        public override void Membershiptype()
        {
            Console.WriteLine("7 days accomodation at resort and 5 dinners on the house");
        }
    }
    public class MembershipImplementation
    {
        public static void Main(string[] args) 
        {
            MembershipImplementation impl = new MembershipImplementation();
            Membership membership;
            Console.WriteLine("Enter choice:" +
                "1 for Gold, 2 for Silver, 3 for Platinum ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice) 
            {
                case 1:
                    membership = new GoldMembership();
                    membership.Membershiptype();
                    break;

                case 2:
                    membership = new SilverMembership();
                    membership.Membershiptype();
                    break;

                case 3:
                    membership= new PlatinumMembership();
                    membership.Membershiptype();
                    break;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
        }
    }
}
