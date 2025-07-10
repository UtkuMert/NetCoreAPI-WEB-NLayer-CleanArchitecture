using Microsoft.EntityFrameworkCore;

namespace App.Repositories.Products
{
    internal class ProductRepository(AppDbContext context): GenericRepository<Product>(context), IProductRepository
    {
        public Task<List<Product>> GetTopPriceProductAsync(int count)
        {
            //tek satirda dondugu icin async await yazmaya gerek yok
            return Context.Products
                .OrderByDescending(p => p.Price)
                .Take(count)
                .ToListAsync();
        }
    }
}
