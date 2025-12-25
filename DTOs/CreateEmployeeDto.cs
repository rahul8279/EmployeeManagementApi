using System.ComponentModel.DataAnnotations;
namespace EmployeeManagementApi.DTOs
{
    public class CreateEmployeeDto
    {
        [Required]
        [MinLength(3)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Department { get; set; }

        [Required]
        [Range(10000, 1000000)]
        public Decimal Salary { get; set; }

    }
}