using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameGrabber.Data;
using GameGrabber.Models;

namespace GameGrabber.Pages.SalesPage
{
    public class CreateModel : PageModel
    {
        private readonly GameGrabber.Data.GameGrabberContext _context;

        public CreateModel(GameGrabber.Data.GameGrabberContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Customer"] = new SelectList(_context.Customers, "CustomerID", "FirstMidName");
        ViewData["Product"] = new SelectList(_context.Product, "ProductID", "ProductName");
            return Page();
        }

        [BindProperty]
        public Sales Sales { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sales.Add(Sales);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
