using DemoSPS.Entities;
using System.Linq.Expressions;

namespace DemoSPS.Services.Abstract
{
    public interface ICacheService
    {
        public Task<List<Product>> GetProduct(Expression<Func<Product, bool>>? expression = null);
    }
}
