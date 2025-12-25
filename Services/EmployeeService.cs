using EmployeeManagementApi.DTOs;
using EmployeeManagementApi.Models;

namespace EmployeeManagementApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static readonly List<Employee> _employees = [];
        private static int IdCounter = 1;

        public EmployeeResponseDto CreateEmployee(CreateEmployeeDto dto)
        {
           var employee = new Employee
           {
             Id = IdCounter++,
             Name =dto.Name,
             Email = dto.Email,
             Department = dto.Department,
             Salary = dto.Salary  
           };

           _employees.Add(employee);

           return new EmployeeResponseDto
           {
               Id = employee.Id,
               Name = employee.Name,
               Email = employee.Email,
               Department = employee.Department,
               Salary = employee.Salary
           };
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(emp =>emp.Id == id)??throw new Exception("cant find employee with this id");
            _employees.Remove(employee);
            System.Console.WriteLine("Employee delete successFully.");
        }

        public EmployeeResponseDto GetEmployeeById(int id)
        {
            var employee = _employees.FirstOrDefault(emp => emp.Id == id) ?? throw new Exception("Cannot found Employee  with this Id");
            return new EmployeeResponseDto
            {
              Name = employee.Name,
              Department = employee.Department,
              Id = employee.Id,
              Salary = employee.Salary
            };
        }

        public List<EmployeeResponseDto> GetEmployees()
        {
            return _employees.Select(emp => new EmployeeResponseDto
            {
                Id = emp.Id,
                Name = emp.Name,
                Email = emp.Email,
                Department = emp.Department,
                Salary = emp.Salary
            }).ToList();
        }

        public void UpdateEmployee(int id, UpdateEmployeeDto dto)
        {
           var employee = GetEmployeeById(id);
           employee.Name = dto.Name;
           employee.Salary = dto.Salary;
           System.Console.WriteLine("Employee update successfully.");
        }
    }
}