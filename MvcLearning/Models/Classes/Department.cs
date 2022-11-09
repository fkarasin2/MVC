using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Department
{
    [Key]
    public int departmentId { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string departmentName { get; set; }

    public bool status { get; set; }

    public ICollection<Personal> Personals { get; set; }
}