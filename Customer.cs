using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("customers")]
[Index(nameof(Email), IsUnique = true)]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Email { get; set; }
    public List<Order> Orders { get; set; }
}