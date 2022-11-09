using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Currrent
{
    [Key]
    public int currentId { get; set; }
    
    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string currentName { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string currentSurname { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(15)]
    public string currentCity { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(50)]
    public string currentMail { get; set; }

    public ICollection<SalesMovement> SalesMovements { get; set; }
}