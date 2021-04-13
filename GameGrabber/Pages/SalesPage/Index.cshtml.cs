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
    public class IndexModel : PageModel
    {
        private readonly GameGrabber.Data.GameGrabberContext _context;

        public IndexModel(GameGrabber.Data.GameGrabberContext context)
        {
            _context = context;
        }

        public IList<Sales> Sales { get;set; }

        public async Task OnGetAsync()
        {
            Sales = await _context.Sales.ToListAsync();
        }
    }
}
