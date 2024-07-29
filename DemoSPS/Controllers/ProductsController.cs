using DemoSPS.Data;
using DemoSPS.Entities;
using DemoSPS.Services;
using DemoSPS.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DemoSPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ICacheService _cacheService;

        public ProductsController(AppDbContext context,
            ICacheService cacheService)
        {
            _context = context;
            _cacheService = cacheService;
        }
        [HttpGet("api/san-pham")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _cacheService.GetProduct());
        }
    }
}
