using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Data;

public class CarSale
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime SaleDate { get; set; }
    
    [Required]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    
    public int? CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    
    public int CarId { get; set; }
    public virtual Car Car { get; set; }
    
}