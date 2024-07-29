using DemoSPS.Data;
using DemoSPS.Entities;
using DemoSPS.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DemoSPS.Services
{
    public class CacheService : ICacheService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public CacheService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task<List<Product>> GetProduct(Expression<Func<Product, bool>>? expression = null)
        {
            using(var _context = await _dbContextFactory.CreateDbContextAsync())
            {
                return expression == null ? await _context.Products.ToListAsync() :
                    await _context.Products.Where(expression).ToListAsync();
            }
        }
    }
}
