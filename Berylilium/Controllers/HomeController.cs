using Berylilium.DAL;
using Berylilium.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Berylilium.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                bnr = await _db.banners.ToListAsync(),
                hdt = _db.HeadingTexts.First(),
                testimoni = await _db.Testimonials.ToListAsync()
            };
            return View(hvm);
        }
    }
}