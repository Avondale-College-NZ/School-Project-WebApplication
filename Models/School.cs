using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesSchool.Models
{
    public class School
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}