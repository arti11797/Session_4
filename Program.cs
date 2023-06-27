using Microsoft.EntityFrameworkCore;
using WebAppSession_4.Contex;
using WebAppSession_4.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string con = builder.Configuration.GetConnectionString("localstr");
builder.Services.AddDbContext<ApplicationDbCon>(options=>options.UseSqlServer(con));
builder.Services.AddScoped<IProductRepo, ProductRepo >();

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
