#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment3.Data;
using Assignment3.Models;

namespace Assignment3.Pages.OrderItems
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment3.Data.DataBaseContext _context;

        public DetailsModel(Assignment3.Data.DataBaseContext context)
        {
            _context = context;
        }

        public OrderItem OrderItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderItem = await _context.OrderItems.FirstOrDefaultAsync(m => m.ProductID == id);

            if (OrderItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
