using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EauClaireSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    [Required]
    public string Name { get; set; }

    public int StylistId { get; set; }

    public Stylist Stylist { get; set; }
  }
}
