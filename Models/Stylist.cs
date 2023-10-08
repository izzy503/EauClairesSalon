using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EauClaireSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Specialty { get; set; }

    public List<Client> Clients { get; set; }
  }
}

