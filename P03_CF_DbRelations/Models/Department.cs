using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P03_CF_DbRelations.Models
{
    public class Department
    {
        [Key] // DepartmentID alanı anahtar bir alan olacak
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // bu alan oto artış
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Departman Adı gereklidir")]
        [StringLength(30, ErrorMessage = "Departman Adı max.30 dur")]
        [Display(Name = "Departman Adı")]
        public string DepartmentName { get; set; }

        // Relation
        public ICollection<Personel> Personels { get; set; } // Department --> Personel besliyor
    }
}
