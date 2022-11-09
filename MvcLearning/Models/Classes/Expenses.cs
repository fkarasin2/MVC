using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Expenses
{
    [Key] 
    public int expenseID { get; set; }
    
    [Column(TypeName = "Varchar")]
    [StringLength(100)]
    public string expenseDescription { get; set; }

    public DateTime expenseDate { get; set; }

    public decimal expensePrice { get; set; }
}