using TrklPPR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TrklPPRContext>(options =>
 options.UseSqlite(builder.Configuration.GetConnectionString("TrklPPRContext")
?? throw new InvalidOperationException("Connection string 'TrklPPRContext' notfound.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TrklPPRContext>();

builder.Services.AddDbContext<TrklPPRContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("TrklPPRContext")
?? throw new InvalidOperationException("Connection string 'TrklPPRContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
 var services = scope.ServiceProvider.GetRequiredService<TrklPPRContext>();
 SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

