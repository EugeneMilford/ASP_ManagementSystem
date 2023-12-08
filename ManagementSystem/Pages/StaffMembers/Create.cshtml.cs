using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Data;
using ManagementSystem.Models;

namespace ManagementSystem.Pages.StaffMembers
{
    public class CreateModel : PageModel
    {
        private readonly ManagementSystem.Data.ManagementContext _context;

        public CreateModel(ManagementSystem.Data.ManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Staff Staff { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Personnel.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
