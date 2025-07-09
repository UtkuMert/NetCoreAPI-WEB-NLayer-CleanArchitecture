using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return services;
            // Diğer repository'leri de buraya ekleyebilirsiniz
        }
    }
}
