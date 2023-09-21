using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using IntroToUsers_Lab5.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IntroToUsersContextConnection") ?? throw new InvalidOperationException("Connection string 'IntroToUsersContextConnection' not found.");

builder.Services.AddDbContext<IntroToUsersContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<DemoUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IntroToUsersContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers(
    options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

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
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(name: "default", pattern: "<pattern>");

// include Razor Pages middleware to routing
app.MapRazorPages();

app.Run();
