using System.ComponentModel.DataAnnotations;

namespace Crypto.Models;

public class Asset
{
    public int AssetId { get; set; }
    
    [Required(ErrorMessage = "The price is required")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "The price is required")]
    [Range(0.00000001, double.MaxValue, ErrorMessage = "The price must be greater than zero")]
    public double? Price { get; set; }

    [Required]
    public int? CategoryId { get; set; }

    public bool? Liked { get; set; } // new

}
