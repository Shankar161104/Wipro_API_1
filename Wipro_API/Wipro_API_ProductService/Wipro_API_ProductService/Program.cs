using Wipro_API_ProductService.Model;
using Wipro_API_ProductService.EntityFramework;
using Wipro_API_ProductService.Repository;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnection")));
builder.Services.AddTransient<IProductService, ProductService>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
