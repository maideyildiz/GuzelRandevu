using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuzelRandevu.Data;
using GuzelRandevu.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;

namespace GuzelRandevu.Controllers
{
    public class RandevuController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Uye> _userManager;
        private readonly ILogger<RandevuController> _logger;
        private readonly IStringLocalizer<RandevuController> _localizer;
        public RandevuController(ApplicationDbContext context, UserManager<Uye> userManager, ILogger<RandevuController> logger, IStringLocalizer<RandevuController> localizer)
        {
            _localizer = localizer;
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) }
            );

            return LocalRedirect(returnUrl);
        }
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var liste = _context.Randevu.Include(r => r.guzellikMerkezi).Include(r => r.uye).Where(r => r.uye.Id == userId);
            if (liste == null)
            {
                return NotFound();
            }
            return View(await liste.ToListAsync());
        }
        [AllowAnonymous]
        // GET: Randevu/Details/5
        public async Task<IActionResult> Details(string merkezId,string uyeId)
        {
            if (merkezId == null && uyeId==null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == merkezId && m.uyeId==uyeId);
            if (randevu == null)
            {
                return NotFound();
            }
            ViewBag.gunu = randevu.randevuSaati;
            return View(randevu);
        }
        [Authorize]
        // GET: Randevu/Create
        public IActionResult Create()
        {
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId");
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["Email"] = new SelectList(_context.Users, "Email", "Email");
            ViewData["merkezAdi"] = new SelectList(_context.GuzellikMerkezi, "merkezAdi", "merkezAdi");
            ViewData["uyeAdi"] = new SelectList(_context.Users, "uyeAdi", "uyeAdi");
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.userId = userId;
            return View();
        }

        // POST: Randevu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(randevu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }
        [Authorize]
        // GET: Randevu/Edit/5
        public async Task<IActionResult> Edit(string merkezId,string uyeId)
        {
            if (merkezId == null && uyeId==null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu.FindAsync(merkezId,uyeId);
            if (randevu == null)
            {
                return NotFound();
            }
            ViewBag.gun = randevu.randevuSaati;
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }

        // POST: Randevu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string merkezId,string uyeId, [Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (merkezId != randevu.merkezId && uyeId!=randevu.uyeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(randevu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RandevuExists(randevu.merkezId,randevu.uyeId))
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
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }
        [Authorize]
        // GET: Randevu/Delete/5
        public async Task<IActionResult> Delete(string merkezId,string uyeId)
        {
            if (merkezId == null&& uyeId==null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == merkezId && m.uyeId==uyeId);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // POST: Randevu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string merkezId,string uyeId)
        {
            var randevu = await _context.Randevu.FindAsync(merkezId,uyeId);
            _context.Randevu.Remove(randevu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RandevuExists(string merkezId,string uyeId)
        {
            return _context.Randevu.Any(e => e.merkezId == merkezId && e.uyeId==uyeId);
        }
    }
}
