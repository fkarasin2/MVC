using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Admin : IEntity
{
    [Key]
    public int AdminId { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(15)]
    public string userName { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string password { get; set; }

    [Column(TypeName = "Char")]
    [StringLength(10)]
    public string permission { get; set; }
}
public interface IEntity
{

}

