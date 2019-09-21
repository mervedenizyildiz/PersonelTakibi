using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi.Models
{
    public enum Departman
    {
    }
    public class Employee
    {
        public enum Gender
        {
            Male,Female,Karışık
        }


        public Employee()
        {
            this.ID = new Guid();
        }
        public Guid ID { get; set; }
        [Required,MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required,MaxLength(24)]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [MaxLength(150)]
        public string ImageUrl { get; set; }






    }
}
