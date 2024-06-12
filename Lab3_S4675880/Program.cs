using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// For the Product DbContext
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbContext") ?? throw new InvalidOperationException("Connection string 'ProductDbContext' not found.")));

// For the Manager DbContext
builder.Services.AddDbContext<ManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ManagerDbContext") ?? throw new InvalidOperationException("Connection string 'ManagerDbContext' not found.")));

// For the Client DbContext
builder.Services.AddDbContext<ClientDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ClientDbContext") ?? throw new InvalidOperationException("Connection string 'ClientDbContext' not found.")));

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
