using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BaseClass
    {
        public void CalculateTax(double vat,double price)
        {
            double tax=price * vat;
            Console.WriteLine("VAT: " + tax);
        }
    }
    class DerivedClass : BaseClass
    {
        public new void CalculateTax(double gst,double price)
        {
            double tax = price * gst;
            Console.WriteLine("GST: " + tax);
        }
    }
    class TaxCalculation
    {
        static void Main(string[] args)
        {
            BaseClass bobj = new BaseClass();
            bobj.CalculateTax(5, 500);
            DerivedClass dobj=new DerivedClass();
            dobj.CalculateTax(2.5, 400);
        }
    }
}