using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SupplierController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> ConsultSupplier()
        {
            return Ok(await _context.Suppliers.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddSupplier(Supplier Supplier) 
        {
            _context.Suppliers.Add(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSupplier(Supplier Supplier)
        {
            _context.Update(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSupplier(Supplier Supplier)
        {
            _context.Remove(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);
        }
    }
}
