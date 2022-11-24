using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Product

        [HttpGet]

        public async Task<IActionResult> ConsultProduct()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product Product) 
        {
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product Product)
        {
            _context.Update(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(Product Product)
        {
            _context.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);
        }
    }
}
