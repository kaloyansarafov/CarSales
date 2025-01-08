using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Data;

public class Car
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Brand { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Model { get; set; }
    [Required]
    public int Year { get; set; }
    
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public virtual CarSale? CarSale { get; set; } = null;

    public bool IsSold { get; set; } = false;
    
    public string FullName => $"{Year} {Brand} {Model}";
}