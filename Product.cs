using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("products")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Column(TypeName = "text")]
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
}