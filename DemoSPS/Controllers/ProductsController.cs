using DemoSPS.Data;
using DemoSPS.Entities;
using DemoSPS.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoSPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ICacheService _cacheService;

        public ProductsController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }
        [HttpGet("api/san-pham")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _cacheService.GetProduct());
        }
    }
}
