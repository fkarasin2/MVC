using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Product
{
    [Key]
    public int productId { get; set; }
    
    
    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string productName { get; set; }
    
    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string productBrand { get; set; }

    public short stockCounts { get; set; }

    public decimal buyPrice { get; set; }

    public decimal sellPrice { get; set; }

    public bool state { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(250)]
    public string productImg { get; set; }

    public int categoryID { get; set; }
    public virtual Category Category { get; set; }

    public ICollection<SalesMovement> SalesMovements { get; set; }
}