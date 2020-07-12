using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data.Access;
using Entities;
using Data.Repositories.Abstraction;
using Services;
using Services.Abstraction;

namespace OnlineShop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: Item
        public async Task<IActionResult> Index()
        {
            return View(await _itemService.GetAllAsync());
        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = (await _itemService.GetAllAsync())
                .FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,Id,Name,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                //item.Id = Guid.NewGuid();
                //_itemService.Add(item);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));


                //item.Id = Guid.NewGuid();
                await _itemService.CreateAsync(item);
                return RedirectToAction(nameof(Index));
            }

            return View(item);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _itemService.GetAsync((Guid)id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("OrderId,Id,Name,UpdatedDate")] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _itemService.UpdateAsync(item);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await ItemExists(item.Id))
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
            return View(item);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _itemService.RemoveAsync((Guid)id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        
        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var item = await _itemService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        

        private async Task<bool> ItemExists(Guid id)
        {
            return (await _itemService.GetAsync(id)) != null;
        }
    }
}
