using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSchool.Models;

namespace School_Project_WebApplication.Data
{
    public class School_Project_WebApplicationContext : DbContext
    {
        public School_Project_WebApplicationContext (DbContextOptions<School_Project_WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSchool.Models.School> School { get; set; }
    }
}
