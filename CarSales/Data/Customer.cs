using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Data;

public class Customer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    [Required]
    [MaxLength(255)]
    public required string Address { get; set; }
    [Required]
    [MaxLength(10)]
    public required string ZipCode { get; set; }
    [Required]
    [MaxLength(100)]
    public required string City { get; set; }
    [Required]
    [Phone]
    [MaxLength(15)]
    public required string Phone { get; set; }
    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public required string Email { get; set; }
    
    public virtual ICollection<CarSale>? CarSales { get; set; }
}