using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicCrud.API.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [RegularExpression(@"^[A-Za-z.\s]+$",
            ErrorMessage = "Name can contain only letters, spaces and dots. No numbers or special characters allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(150)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(100)]
        public string Department { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(1, 10000000, ErrorMessage = "Salary must be greater than 0")]
        [Column(TypeName = "numeric(18,2)")]
        public decimal Salary { get; set; }
    }
}
