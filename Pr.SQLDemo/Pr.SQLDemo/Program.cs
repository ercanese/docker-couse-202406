using Microsoft.EntityFrameworkCore;
using Pr.SQLDemo.Models;

var builder = WebApplication.CreateBuilder(args);
var connstrn = builder.Configuration.GetConnectionString("DB");
builder.Services.AddDbContext<UsersDBContext>(options =>
{
    //options.UseSqlServer("Data Source=172.16.20.140;Initial Catalog=Demo;User ID=sa;Password=Deneme123456!;TrustServerCertificate=True");
    options.UseSqlServer(connstrn);
});
// Add services to the container.
builder.Services.AddControllersWithViews();

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
