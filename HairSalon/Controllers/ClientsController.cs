using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClaireSalon.Models;
using System.Linq;

namespace EauClaireSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly EauClaireSalonContext _context;

        public ClientsController(EauClaireSalonContext context)
        {
            _context = context;
        }

        // GET: Clients
        public ActionResult Index()
        {
            var clients = _context.Clients.ToList();
            return View(clients);
        }

        // GET: Clients/Create
        public ActionResult Create(int stylistId)
        {
            var client = new Client { StylistId = stylistId };
            return View(client);
        }

        // POST: Clients/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("Index", "Stylists");
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
    }
}
