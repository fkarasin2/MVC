using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLearning.Models.Classes;

public class Invoice
{
    [Key] 
    public int invoiceId { get; set; }

    [Column(TypeName = "Char")]
    [StringLength(10)]
    public string invoiceSerialNo { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string invoiceSortNo { get; set; }

    public DateTime invoiceDate { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string taxBranch { get; set; }

    public DateTime invoiceHour { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string invoiceSubmitter { get; set; }

    [Column(TypeName = "Varchar")]
    [StringLength(40)]
    public string invoiceDelivery { get; set; }

    public ICollection<FaturaKalem> FaturaKalems { get; set; }
}