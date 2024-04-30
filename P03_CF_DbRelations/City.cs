using P03_CF_DbRelations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P03_CF_DbRelations
{
    public class City
    {
        [Key] // DepartmentID alanı anahtar bir alan olacak
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // bu alan oto artış
        public int CityID { get; set; }

        [Required(ErrorMessage = "Şehir Adı gereklidir")]
        [StringLength(30, ErrorMessage = "Şehir Adı max.30 dur")]
        [Display(Name = "Şehir Adı")]
        public string CityName { get; set; }

        // Relation
        public ICollection<Personel> Personels { get; set; } // City --> Personel besliyor
    }
}
