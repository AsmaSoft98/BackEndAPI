using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _context.Employees.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee Employee)
        {
            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee Employee)
        {
            _context.Update(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(Employee Employee)
        {
            _context.Remove(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }

    }
}
