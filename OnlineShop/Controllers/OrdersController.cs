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
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: Order
        public async Task<IActionResult> Index()
        {
            return View(await _orderService.GetAllAsync());
        }

        // GET: Order/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = (await _orderService.GetWithItemsAsync((Guid)id));
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Order/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,Id,Name,UpdatedDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderService.CreateAsync(order);
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }

        // GET: Order/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _orderService.GetWithItemsAsync((Guid)id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,OrderStatus")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _orderService.UpdateAsync(order);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await OrderExists(order.Id))
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
            return View(order);
        }

        // GET: Order/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _orderService.RemoveAsync((Guid)id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        /*
         * // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        private async Task<bool> OrderExists(Guid id)
        {
            return (await _orderService.GetAsync(id)) != null;
        }
    }
}
