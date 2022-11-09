using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Personal
{
    [Key]
    public int personalId { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string personalName { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string personalSurname { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(250)]
    public string personalImg { get; set; }

    public ICollection<SalesMovement> SalesMovements { get; set; }

    public int DepartmentId { get; set; }
    
    public virtual Department Department { get; set; }
}