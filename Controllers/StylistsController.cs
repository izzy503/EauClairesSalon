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
    public async Task<IActionResult> Index()
    {
      var stylists = await _context.Stylists.ToListAsync();
      return View(stylists);
    }

    // GET: Stylists/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var stylist = await _context.Stylists
          .Include(s => s.Clients)
          .FirstOrDefaultAsync(m => m.StylistId == id);

      if (stylist == null)
      {
        return NotFound();
      }

      return View(stylist);
    }

    // GET: Stylists/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Stylists/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("StylistId,Name,Specialty")] Stylist stylist)
    {
      if (ModelState.IsValid)
      {
        _context.Add(stylist);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(stylist);
    }

    // GET: Stylists/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var stylist = await _context.Stylists.FindAsync(id);

      if (stylist == null)
      {
        return NotFound();
      }

      return View(stylist);
    }

    // POST: Stylists/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("StylistId,Name,Specialty")] Stylist stylist)
    {
      if (id != stylist.StylistId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(stylist);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!StylistExists(stylist.StylistId))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(Index));
      }
      return View(stylist);
    }

    // GET: Stylists/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var stylist = await _context.Stylists
          .FirstOrDefaultAsync(m => m.StylistId == id);

      if (stylist == null)
      {
        return NotFound();
      }

      return View(stylist);
    }

    // POST: Stylists/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var stylist = await _context.Stylists.FindAsync(id);
      _context.Stylists.Remove(stylist);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool StylistExists(int id)
    {
      return _context.Stylists.Any(e => e.StylistId == id);
    }
  }
}
