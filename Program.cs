using EmployeeManagementApi.Services;

namespace EmployeeManagementApi
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddScoped<IEmployeeService,EmployeeService>();
            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.UseRouting();
            app.MapControllers();
            app.Run();
        }
    }
}