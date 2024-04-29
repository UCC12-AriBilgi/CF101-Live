using System.ComponentModel.DataAnnotations.Schema;

namespace P01_CF.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        // Data Annotations

        [Column(TypeName = "NVarchar(20)")]
        public string SFName { get; set; }

        [Column(TypeName = "NVarchar(30)")]
        public string SLName { get; set; }

        public DateTime SDoB {  get; set; }

        // Relational Definitions
        public virtual Standard Standard { get; set; } // Standart a bağlıyım




    }
}
