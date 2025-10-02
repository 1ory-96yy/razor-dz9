using System.ComponentModel.DataAnnotations;

public class Product
{
    [Required]
    public string Name { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [Range(1, 10000)]
    public decimal Price { get; set; }
}
