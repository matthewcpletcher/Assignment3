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

namespace Assignment3.Pages.DeliveryP
{
    public class IndexModel : PageModel
    {
        private readonly Assignment3.Data.DataBaseContext _context;

        public IndexModel(Assignment3.Data.DataBaseContext context)
        {
            _context = context;
        }

        public IList<DeliveryPerson> DeliveryPerson { get;set; }
        public IList<OrderItem> OrderItems { get;set; }

        public async Task OnGetAsync()
        {
            DeliveryPerson = await _context.DeliveryPeople.ToListAsync();
            OrderItems = await _context.OrderItems.ToListAsync();
        }
    }
}
