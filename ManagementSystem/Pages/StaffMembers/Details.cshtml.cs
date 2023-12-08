using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Data;
using ManagementSystem.Models;

namespace ManagementSystem.Pages.StaffMembers
{
    public class DetailsModel : PageModel
    {
        private readonly ManagementSystem.Data.ManagementContext _context;

        public DetailsModel(ManagementSystem.Data.ManagementContext context)
        {
            _context = context;
        }

      public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Personnel == null)
            {
                return NotFound();
            }

            var staff = await _context.Personnel.FirstOrDefaultAsync(m => m.ID == id);
            if (staff == null)
            {
                return NotFound();
            }
            else 
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
