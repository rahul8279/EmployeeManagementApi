using EmployeeManagementApi.DTOs;
namespace EmployeeManagementApi.Services
{
    public interface IEmployeeService
    {
        List<EmployeeResponseDto> GetEmployees();
        EmployeeResponseDto GetEmployeeById(int id);
        EmployeeResponseDto CreateEmployee(CreateEmployeeDto dto);
        void UpdateEmployee(int id, UpdateEmployeeDto dto);
        void DeleteEmployee(int id);
    }
}