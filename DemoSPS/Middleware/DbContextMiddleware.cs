using DemoSPS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DemoSPS.Middleware
{
    public class DbContextMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public DbContextMiddleware(RequestDelegate next,
            IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _next = next;
            _dbContextFactory = dbContextFactory;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var dbContext = _dbContextFactory.CreateDbContext();
            context.Items["dbContext"] = dbContext;
            try
            {
                await _next(context);
            }
            finally
            {
                if (context.Items["DbContext"] is DbContext contextDb)
                {
                    contextDb.Dispose();
                }
            }
        }
    }
}
