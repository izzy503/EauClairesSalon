using System.Collections.Generic;
using EauClaireSalon.Models;
namespace EauClaireSalon.ViewModels;
public class StylistDetailsViewModel
{
  public Stylist Stylist { get; set; }
  public List<Client> Clients { get; set; }
}
