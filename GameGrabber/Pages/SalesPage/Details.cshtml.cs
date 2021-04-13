using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameGrabber.Data;
using GameGrabber.Models;

namespace GameGrabber.Pages.SalesPage
{
    public class DetailsModel : PageModel
    {
        private readonly GameGrabber.Data.GameGrabberContext _context;

        public DetailsModel(GameGrabber.Data.GameGrabberContext context)
        {
            _context = context;
        }

        public Sales Sales { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sales = await _context.Sales.FirstOrDefaultAsync(m => m.SalesID == id);

            if (Sales == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
