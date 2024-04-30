using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_CF_DbRelations.Models
{
    // Data-Annotation attribute lar ilgili alan tanımı öncesinde yapılmaktadır.
    public class Category
    {
        [Key] // CategoryID alanı anahtar bir alan olacak
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // bu alan oto artış
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Kategori Adı gereklidir")]
        [StringLength(30,ErrorMessage = "Kategori Adı max.30 dur")]
        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }

        // Relation
        public ICollection<Product> Products { get; set; } // Category --> Product besliyor

    }
}
