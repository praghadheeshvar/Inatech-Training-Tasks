using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    internal class Link1
    {
        public static void Main(string[] args)
        {
            string[] names = { "Praggi", "Vignesh", "Prathibha", "Boomica" };
            var qry = from name in names
                      where name.Contains('e')
                      select name;
            foreach (var name in qry)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Students class members:");
            Student[] studata = { new Student() { studentID = 1, studentname ="Praggi",age=21},
             new Student() {studentID=2,studentname="Vignesh",age=22},
             new Student() {studentID=3,studentname="Rishab",age=21 },
             new Student() {studentID=4,studentname="Prathibha",age=23},
             new Student(){studentID=5,studentname="Boomica",age=24}
            };
            foreach (Student student in studata)
            {
                Console.WriteLine(student.studentID + " " + student.studentname + " " + student.age);
            }
            Console.WriteLine("---------------------------------");
            var qr = from Students in studata
                     where Students.age > 21
                     where Students.age < 22
                     select Students;
            foreach (Student s in qr)
            {
                Console.WriteLine(s.studentID + " " + s.studentname + " " + s.age);
            }
            Console.WriteLine("----------------------------");
            var sqr = from Students in studata
                      where Student.IsEmployable(Students)
                      select Students;
            foreach (Student st in sqr)
            {
                Console.WriteLine(st.studentID + " " + st.studentname + " " + st.age);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Filtering By Age");
            var employablestudents = studata.Where(s => s.age > 18 && s.age < 22);
            foreach (Student st in employablestudents)
            {
                Console.WriteLine(st.studentID + " " + st.studentname);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Filtering Even ID 1st Method");
            var evenid = studata.Where(s => s.studentID % 2 == 0);
            foreach (Student s in evenid)
            {
                Console.WriteLine(s.studentID + " " + s.studentname);
            }
            Console.WriteLine("-----------------------------------------");
            Subjects[] sub = { 
                new Subjects() { Topic = "International Politics", Faculty = "Rishab" },
                new Subjects() { Topic="International Cuisine", Faculty="Guganesh"},
                new Subjects() { Topic="International Trader", Faculty="Naman"},
                new Subjects() { Topic="International Sports", Faculty="Vignesh"},
                new Subjects() { Topic="International Literature", Faculty="Boomica"}
            };
            var EvenRows = sub.Where((j, i) =>
            {
                if (i % 2 == 0) return true;
                return false;
            });
            foreach(var row in EvenRows)
            {
                Console.WriteLine(row.Topic + ": " + row.Faculty);
            }
            Console.WriteLine("-------------------------------------");
            var Facqry = from sb in sub
                         orderby sb.Faculty 
                         select sb;
            foreach(Subjects ss in Facqry)
            {
                Console.WriteLine(ss.Topic+" "+ ss.Faculty);
            }
            Console.WriteLine("-------------------------------------");
            var Faqry = from sb in sub
                         orderby sb.Faculty descending
                         select sb;
            foreach (Subjects ss in Faqry)
            {
                Console.WriteLine(ss.Topic + " " + ss.Faculty);
            }
            Console.WriteLine("------------------------------------------");
            var Fqry = from students in studata
                       orderby students.studentname
                     orderby students.age descending
                       select students;
            foreach(Student s in Fqry) 
            {
                Console.WriteLine(s.studentname + " " + s.age);
            }
        }
        public class Student
        {
            public int studentID { get; set; }
            public string studentname { get; set; }
            public int age { get; set; }
            public static bool IsEmployable(Student student)
            {
                return student.age > 18 && student.age < 22;
            }
        }
        public class Subjects
        {
            public string Topic { get; set; }
            public string Faculty { get; set; }
        }
    }
}
