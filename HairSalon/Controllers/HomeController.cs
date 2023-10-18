using Microsoft.AspNetCore.Mvc;

namespace EauClaireSalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}