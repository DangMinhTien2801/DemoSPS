using DemoSPS.Data;
using DemoSPS.Entities;
using DemoSPS.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq.Expressions;

namespace DemoSPS.Services
{
    public class CacheService : ICacheService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CacheService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<Product>> GetProduct(Expression<Func<Product, bool>>? expression = null)
        {
            var _context = _httpContextAccessor?.HttpContext?.RequestServices.GetRequiredService<AppDbContext>() ?? null!;
            return expression == null ? await _context.Products.ToListAsync() :
                        await _context.Products.Where(expression).ToListAsync();
        }
    }
}
