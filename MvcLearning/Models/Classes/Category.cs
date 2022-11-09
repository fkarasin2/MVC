using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Category
{
    [Key]
    public int categoryId { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string categoryName { get; set; }

    public ICollection<Product> Products { get; set; }
}