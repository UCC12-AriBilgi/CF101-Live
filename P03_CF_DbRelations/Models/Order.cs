using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_CF_DbRelations.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        // Relation
        public virtual Personel Personels { get; set; } // Order <-- Personel

        public virtual Product Products { get; set; } // Order <-- Product
    }
}
