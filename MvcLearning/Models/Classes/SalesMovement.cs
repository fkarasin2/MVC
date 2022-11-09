using System.ComponentModel.DataAnnotations;

namespace MvcLearning.Models.Classes;

public class SalesMovement
{
    [Key] 
    public int salesMovementId { get; set; }

    public DateTime salesMovementDate { get; set; }

    public int count { get; set; }

    public decimal price { get; set; }

    public decimal totalPrice { get; set; }

    public Product Product { get; set; }
    
    public Currrent Currrent { get; set; }
    
    public Personal Personal { get; set; }
}