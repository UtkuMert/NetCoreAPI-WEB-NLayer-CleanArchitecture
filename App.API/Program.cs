using App.Repositories;
using App.Repositories.Extension;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepositories(builder.Configuration); // Repositories ekleme islemleri


#region Comments
/* bi extension yazarak buradaki uzun islemleri kaldirdik*/
//builder.Services.AddDbContext<AppDbContext>(options =>
//{
//    var connectionSting = builder.Configuration.GetSection(ConnectionStringOption.Key)
//        .Get<ConnectionStringOption>();

//    options.UseSqlServer(connectionSting!.SqlServer); // SqlServer baglantisi alindi ve kullanildi


//    //options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")); // uzun uzun yazmaya gerek yok
//}); //
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
