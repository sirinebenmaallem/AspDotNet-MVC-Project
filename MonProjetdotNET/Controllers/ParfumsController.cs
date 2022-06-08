using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonProjetdotNET.Data;
using MonProjetdotNET.Data.Services;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Controllers
{
    public class ParfumsController : Controller
    {
        private readonly IParfumsService _service;
        public ParfumsController(IParfumsService service)
        {
            _service = service;
        }
        // GET: ParfumsController
        public async Task<IActionResult >Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get :Parfums/Create
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureURL,FullName,Description")] Parfum parfum)
        {
            if (!ModelState.IsValid)
            {
                return View(parfum);
            }
             await _service.AddAsync(parfum);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        
        public async Task<IActionResult> Details(int id)
        {
            var parfumDetails =await _service.GetByIdAsync(id);

            if (parfumDetails == null) return View("NotFound");
            return View(parfumDetails);
        }


        //Get :Parfums/Create
        public async Task<IActionResult >Edit( int id)
        {
            var parfumDetails = await _service.GetByIdAsync(id);

            if (parfumDetails == null) return View("NotFound");
            return View(parfumDetails);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("PictureURL,FullName,Description")] Parfum parfum)
        {

            if (!ModelState.IsValid)
            {
                return View(parfum);
            }
            await _service.UpdateAsync(id,parfum);
            return RedirectToAction(nameof(Index));
        }




        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var parfumDetails = await _service.GetByIdAsync(id);
            if (parfumDetails == null) return View("NotFound");
            return View(parfumDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }



    }
}
