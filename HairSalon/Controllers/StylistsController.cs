using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClaireSalon.ViewModels;
using EauClaireSalon.Models;
using System.Collections.Generic;
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

    public ActionResult Index()
    {
      var stylists = _context.Stylists.ToList();
      return View(stylists);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      if (ModelState.IsValid)
      {
        _context.Stylists.Add(stylist);
        _context.SaveChanges();

      }
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Details(int id)
    {
      var stylist = _context.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      List<Client> clients = _context.Clients.Where(c => c.StylistId == id).ToList();

      var viewModel = new StylistDetailsViewModel
      {
        Stylist = stylist,
        Clients = clients
      };
      return View(viewModel);
    }
  }
}
