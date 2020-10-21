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
    public class IndexModel : PageModel
    {
        private readonly School_Project_WebApplication.Data.School_Project_WebApplicationContext _context;

        public IndexModel(School_Project_WebApplication.Data.School_Project_WebApplicationContext context)
        {
            _context = context;
        }

        public IList<School> School { get;set; }

        public async Task OnGetAsync()
        {
            School = await _context.School.ToListAsync();
        }
    }
}
