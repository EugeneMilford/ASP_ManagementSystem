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
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Data.ManagementContext _context;

        public IndexModel(ManagementSystem.Data.ManagementContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Personnel != null)
            {
                Staff = await _context.Personnel.ToListAsync();
            }
        }
    }
}
