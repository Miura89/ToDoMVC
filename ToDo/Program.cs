using Microsoft.EntityFrameworkCore;
using System.Data;
using ToDo.Data;
using ToDo.Interfaces;
using ToDo.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BancoContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("TesteDb");
    options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<IDbConnection>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("TesteDb");
    return new Npgsql.NpgsqlConnection(connectionString);
});

builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
