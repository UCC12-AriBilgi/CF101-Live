using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_CF_DbRelations.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Ürün adı gereklidir")]
        public string ProductName { get; set; }

        // Relation
        public virtual Category Categories { get; set; } // Product <-- Category

        public ICollection<Order> Orders { get; set; } // Product --> Order besliyor

    }
}
