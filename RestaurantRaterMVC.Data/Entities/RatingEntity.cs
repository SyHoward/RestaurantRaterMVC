using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantRaterMVC.Data.Entities;

public class RatingEntity
{
    [Key]
    public int Id {get; set;}

    [Required]
    [Range(0,5)]
    public double Score {get; set;}

    [Required]
    [ForeignKey(nameof(RestaurantEntity))]
    public int RestaurantId {get; set;}
    public virtual RestaurantEntity Restaurant {get; set;} = null!;
}
