using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClaireSalon.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EauClaireSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly EauClaireSalonContext _context;

    public StylistsController(EauClaireSalonContext context)
    {
      _context = context;
    }

    // GET: Stylists
    public ActionResult Index()
    {
      var stylists = _context.Stylists.ToList();
      return View(stylists);
    }

    // GET: Stylists/Create
    public ActionResult Create()
    {
      return View();
    }

    // Post: Stylists/Create
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      if (ModelState.IsValid)
      {
        _context.Add(stylist);
        _context.SaveChanges();

      }
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Details(int id)
    {
      Stylist stylist = _context.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylist);
    }
  }
}
