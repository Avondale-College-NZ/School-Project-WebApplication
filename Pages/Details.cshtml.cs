using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSchool.Models;
using School_Project_WebApplication.Data;

namespace School_Project_WebApplication.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly School_Project_WebApplication.Data.School_Project_WebApplicationContext _context;

        public DetailsModel(School_Project_WebApplication.Data.School_Project_WebApplicationContext context)
        {
            _context = context;
        }

        public School School { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            School = await _context.School.FirstOrDefaultAsync(m => m.ID == id);

            if (School == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
