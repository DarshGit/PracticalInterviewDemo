using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CognisunPractical.Data;
using CognisunPractical.Data.Domain;
using CognisunPractical.Models.Order;
using System.Text.Json;

namespace CognisunPractical.Controllers
{
    public class OrdersController : Controller
    {
        private readonly CongnisunDbContext _context;

        public OrdersController(CongnisunDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return _context.Orders != null ?
                        View(await _context.Orders.ToListAsync()) :
                        Problem("Entity set 'CongnisunDbContext.Orders'  is null.");
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public async Task<IActionResult> CreateAsync()
        {

            var products = await _context.ProductMasters.ToListAsync();
            var tax_details = await _context.TaxMaster.ToListAsync();
            //var categories = await _context.Database.

            ViewBag.AllProducts = products;
            ViewBag.TaxMaster = tax_details;

            // Serialize the data and pass it to ViewBag
            ViewBag.CategoryProducts = new List<SelectListItem>
            {
                new SelectListItem { Value = "Electronics", Text = "Electronics" },
                new SelectListItem { Value = "Cosmetics", Text = "Cosmetics" },
                new SelectListItem { Value = "Medicines", Text = "Medicines" },
                new SelectListItem { Value = "Clothing", Text = "Clothing" },
                // Add more items as needed
            };

            var model = new AddOrderViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddOrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                var myorder = new Order();
                myorder.Category = order.Category;
                myorder.Product = order.ProductName;
                myorder.PhoneNumber = order.PhoneNumber;
                myorder.DateOfBirth = order.DateOFBirth;
                myorder.SignatureRequired = order.SigantureRequired;
                myorder.DeliveryDate = order.EstimatedDelivery;
                myorder.Description = order.Description;
                myorder.Quantity = (int)order.Quantity;
                myorder.RecieveStatusUpdate = (bool)order.ReceiveStatusUpdate;
                myorder.TotalAmount = order.TotalAmount;
                myorder.ShippingType = order.ShippingType;


                _context.Add(myorder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(CreateAsync));
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var myorder = new Order();
                    myorder.OrderID = id;
                    myorder.Category = order.Category;
                    myorder.Product = order.Product;
                    myorder.PhoneNumber = order.PhoneNumber;
                    myorder.DateOfBirth = order.DateOfBirth;
                    myorder.SignatureRequired = order.SignatureRequired;
                    myorder.DeliveryDate = order.DeliveryDate;
                    myorder.Description = order.Description;
                    myorder.Quantity = (int)order.Quantity;
                    myorder.RecieveStatusUpdate = (bool)order.RecieveStatusUpdate;
                    myorder.TotalAmount = order.TotalAmount;
                    myorder.ShippingType = order.ShippingType;


                    _context.Update(myorder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'CongnisunDbContext.Orders'  is null.");
            }
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return (_context.Orders?.Any(e => e.OrderID == id)).GetValueOrDefault();
        }
    }
}
