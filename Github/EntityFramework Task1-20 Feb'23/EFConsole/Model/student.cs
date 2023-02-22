using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.Model
{
    public class Student
    {
       // [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        [ForeignKey("Standard")]
        public int StandardRefId { get; set; }
        public Standard Standard { get; set; }
    }
    public class Standard
    {
       // [Key]
        public int StandardId { get; set; }
        public string? StandardName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
