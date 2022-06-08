using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonProjetdotNET.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Controllers
{
    public class ChefsController : Controller
    {
        private readonly AppDbContext _context;
        public ChefsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: ChefsController
        public async Task<IActionResult> Index()
        {
            var allChefs = await _context.Chefs.ToListAsync();
            return View(allChefs);
        }

    }
}
