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
    public class DeleteModel : PageModel
    {
        private readonly Assignment3.Data.DataBaseContext _context;

        public DeleteModel(Assignment3.Data.DataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeliveryPerson DeliveryPerson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeliveryPerson = await _context.DeliveryPeople.FirstOrDefaultAsync(m => m.DPersonID == id);

            if (DeliveryPerson == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeliveryPerson = await _context.DeliveryPeople.FindAsync(id);

            if (DeliveryPerson != null)
            {
                _context.DeliveryPeople.Remove(DeliveryPerson);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
