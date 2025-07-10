using App.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Repositories.Extension
{
    public static class RepositoryExtensions
    {
        // Program.cs'de bu islemlerin yapilmasini engelledik bu sayede program.cs daha temiz kaldi
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            // Repositories ekleme islemleri
            services.AddDbContext<AppDbContext>(options =>
            {
                var connectionSting = configuration.GetSection(ConnectionStringOption.Key)
                    .Get<ConnectionStringOption>();

                options.UseSqlServer(connectionSting!.SqlServer, sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName); // Migration'larin hangi assembly'de oldugunu belirtiyoruz
                }); // SqlServer baglantisi alindi ve kullanildi


            }); //
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); // Generic repository'yi de ekliyoruz>
            services.AddScoped<IUnitOfWork, UnitOfWork>(); // UnitOfWork ekliyoruz

            return services;
            // Diğer repository'leri de buraya ekleyebilirsiniz
        }
    }
}
