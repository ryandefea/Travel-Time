namespace TravelTime.Models
{
    public class Destination
    {
      public int DestinationId { get; set; }
      [Required]
      [StringLength(85)]
      public string City { get; set; }
      [Required]
      [StringLength(56)]
      public string Country { get; set; }
      [Required]
      [StringLength(250)]
      public string Review { get; set; }
      [Required]
      [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
      public int Rating { get; set; }

    }  
}