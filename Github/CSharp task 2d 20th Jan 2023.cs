using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task2
{
    internal class StudentMark
    {
        public static void Main(string[] args)
        {
            float[] Marks = new float[5];
            float Sum = 0;
            Console.WriteLine("Enter 5 subject marks:");
            for(int i = 0;i< 5;i++) 
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());
                Sum += Marks[i];
            }
            float Percentage=(Sum/500)*100;
            Console.WriteLine("the total and percentage of the student is: {0} and {1} respectively",Sum,Percentage);
        }
    }
}
