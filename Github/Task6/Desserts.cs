using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Desserts
    {
        public static void Main()
        {
            ArrayList dessert=new ArrayList();
            dessert.Add("Vanilla IceCream");
            dessert.Add("Brownie");
            dessert.Add("Gulab Jamun");
            dessert.Add("Cake");
            FileStream fs = new FileStream("D:\\Inatech training task\\Inatech Tasks\\Task6\\dssrt.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw= new StreamWriter(fs);
            foreach(object obj in dessert) 
                sw.WriteLine(obj);
                sw.Flush();
                sw.Close();
                fs.Close();
            FileInfo info = new FileInfo("D:\\Inatech training task\\Inatech Tasks\\Task6\\dssrt.txt");
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.Length);
        }
    }
}
