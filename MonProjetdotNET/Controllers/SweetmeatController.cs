using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonProjetdotNET.Data;
using MonProjetdotNET.Data.Services;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Controllers
{
    public class SweetmeatController : Controller
    {
        private readonly ISweetmeatsService _service;
        public SweetmeatController(ISweetmeatsService service)
        {
            _service = service;
        }
        // GET: ParfumsController
         public async Task<IActionResult> Index()
          {
            var data = await _service.GetAll();
              return View(data);
          }


        //Get:SweetmeatShoppingC

        public async Task<IActionResult> ShoppingCard()
        {
            var data = await _service.GetAll();
            return View(data);
        }


        //Get:Sweetmeat/Details/1
        public async Task<IActionResult>Details(int id)
        {
            var sweetmeatDetails = await _service.GetByIdAsync(id);
            if (sweetmeatDetails == null) return View("Empty");
            return View(sweetmeatDetails);
        }


        //Get :Sweetmeats/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var parfumDetails = await _service.GetByIdAsync(id);

            if (parfumDetails == null) return View("NotFound");
            return View(parfumDetails);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Price,ImageURL,SweetmeatCategory,ChefId")] Sweetmeat sweetmeat)
        {

            if (!ModelState.IsValid)
            {
                return View(sweetmeat);
            }
            await _service.UpdateAsync(id, sweetmeat);
            return RedirectToAction(nameof(Index));
        }




        //Get :Sweetmeats/Create
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Price,ImageURL,SweetmeatCategory,ChefId")] Sweetmeat sweetmeat)
        {
            if (!ModelState.IsValid)
            {
                return View(sweetmeat);
            }
            await _service.AddAsync(sweetmeat);
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
