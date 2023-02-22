using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Link.Link1;

namespace Link
{
    internal class Link3
    {
        public static void Main(string[] args)
        {
            IList HList = new ArrayList();
            HList.Add(1);
            HList.Add(2);
            HList.Add("Three");
            HList.Add("Four");
            HList.Add(new Student() { studentID = 1, studentname = "Prathibha" });
            var hliststu = from s in HList.OfType<Student>()
                           select s;
            var hlistint = from s in HList.OfType<int>()
                           select s;
            var hlistval=from s in HList.OfType<string>()
                         select s;
            foreach(Student stu in hliststu)
            {
                Console.WriteLine(stu.studentname);
            }
            foreach (var s in hlistint)
            {
                Console.WriteLine(s);
            }
            foreach(var st in hlistval)
            {
                Console.WriteLine(st);
            }
        }
    }
}
