﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assignment3.Data;
using Assignment3.Models;

namespace Assignment3.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly Assignment3.Data.DataBaseContext _context;

        public CreateModel(Assignment3.Data.DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _context.AddCustomerAsync(Customer);



            return RedirectToPage("./Index");
        }
    }
}
