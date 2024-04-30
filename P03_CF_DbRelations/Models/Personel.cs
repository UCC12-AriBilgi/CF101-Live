using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_CF_DbRelations.Models
{
    public class Personel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonelID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Personel Adı gereklidir")]
        public string FName { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "Personel Soyadı gereklidir")]
        public string LName { get; set; }

        public virtual Department Departments { get; set; } // Personel <-- Department

        public virtual City Cities { get; set; } // Personel <-- City

        public ICollection<Order> Orders { get; set; } // Personel --> Order ı besliyor

    }
}
