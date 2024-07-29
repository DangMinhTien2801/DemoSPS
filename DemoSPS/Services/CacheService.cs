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
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public CacheService(IHttpContextAccessor httpContextAccessor, 
            IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _httpContextAccessor = httpContextAccessor;
            _dbContextFactory = dbContextFactory;
        }
        public async Task<List<Product>> GetProduct(Expression<Func<Product, bool>>? expression = null)
        {
            using(var _context = _httpContextAccessor?.HttpContext?.Items["dbContext"] as AppDbContext ?? await _dbContextFactory.CreateDbContextAsync())
            {
                return expression == null ? await _context.Products.ToListAsync() :
                    await _context.Products.Where(expression).ToListAsync();
            }
        }
    }
}
