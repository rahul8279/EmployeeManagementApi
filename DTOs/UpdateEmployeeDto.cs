using System.ComponentModel.DataAnnotations;
namespace EmployeeManagementApi.DTOs
{
    public class UpdateEmployeeDto
    {
        [Required]
        public string? Name { get; set; }
        [Range(10000, 1000000)]
        public decimal Salary { get; set; }

    }
}