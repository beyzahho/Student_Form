using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Models
{
    public class Student
    {

        public Student()
        {
            CreatedDate = DateTime.Now;
           
            var today = DateTime.Today;

          
           age = today.Year - BirthDate.Year;

           
            if (BirthDate.Date > today.AddYears(-age)) age--;
        }
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        [Required]
        public String Surname { get; set; }
        public String Department { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int? height { get; set; }
        public int age { get; set; }
        public int? weight { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
