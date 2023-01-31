using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class EmployeeDetails
    {

        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public string EmpGender { get; set; }
        public int Empage { get; set; }
        public void getData()
        {
            FileStream fs = new FileStream("D:\\Inatech training task\\Inatech Tasks\\Task6\\Emp.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }
    }
    internal class Employees
    {
        public static void Main()
        {
            EmployeeDetails edobj = new EmployeeDetails();
            Console.WriteLine("Enter employee name:");
            edobj.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee id:");
            edobj.EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender:");
            edobj.EmpGender = Console.ReadLine();
            Console.WriteLine("Enter age:");
            edobj.Empage = Convert.ToInt32(Console.ReadLine());
            FileStream emp = new FileStream("D:\\Inatech training task\\Inatech Tasks\\Task6\\Emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(emp);
            sw.WriteLine(edobj.EmpName);
            sw.WriteLine(edobj.EmpID);
            sw.WriteLine(edobj.EmpGender);
            sw.WriteLine(edobj.Empage);
            sw.Flush();
            sw.Close();
            emp.Close();
        }
    }
}
