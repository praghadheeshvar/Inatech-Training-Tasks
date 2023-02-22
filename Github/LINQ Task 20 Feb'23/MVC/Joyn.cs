using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Link.Link1;

namespace Link
{
    internal class Joyn
    {
        public static void Main()
        {
            IList<Branch>BranchData= new List<Branch>()
            {
                new Branch() {BranchID=1,BranchName="Information Technology"},
                new Branch() { BranchID=2,BranchName="Computer Science"},
                new Branch() { BranchID=3,BranchName="Electrical and Electronics"}
            };
            IList<Student> StuData = new List<Student>()
            {
                new Student(){ studentID = 1 , studentname="Rishab",age =22, BranchID =1},
                new Student(){ studentID = 2 , studentname="Pragdeesh",age =23,BranchID =2},
                new Student(){ studentID = 3 , studentname="Naman", age = 21, BranchID =2},
                new Student(){ studentID = 4 , studentname="Guganesh", age = 21, BranchID =1},
                new Student(){ studentID = 5 , studentname ="Vignesh" , age= 23, BranchID =3},
                new Student(){ studentID = 6 , studentname ="Calvin", age =21, BranchID =3},
                new Student(){ studentID = 7 , studentname ="Kalakriti", age =22, BranchID =2},
                new Student(){ studentID = 8 , studentname = "Padmavathy", age =20, BranchID = 4}
            };
            var joindata=Student.join
                (
                BranchData,
                
                )
        }
    }
    public class Branch
    {
        public int BranchID { get; set; }
        public string? BranchName { get; set; }
    }
}
