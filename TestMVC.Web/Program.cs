using Microsoft.EntityFrameworkCore;
using TestMVC.Core.MapperProfiles;
using TestMVC.DomainModels.DatabaseContext;
using TestMVC.DomainModels.Models;
using TestMVC.Repository.AgreementsRepository;
using TestMVC.Repository.ProductGroupRepository;
using TestMVC.Repository.ProductRepository;

var builder = WebApplication.CreateBuilder(args);

#region Database Configuration
var connectionString = builder.Configuration.GetConnectionString("TestMVCWebContextConnection"); ;

builder.Services.AddDbContext<ApplicationDatabaseContext>(
    options =>
        options.UseSqlServer(
            connectionString,
            x => x.MigrationsAssembly("TestMVC.DomainModels")));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDatabaseContext>();
#endregion

#region Repositories Injection
builder.Services.AddTransient<IAgreementRepository, AgreementRepository>();
builder.Services.AddTransient<IProductGroupRepository, ProductGroupRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();
// add automapper configuration
builder.Services.AddAutoMapper(configAction =>
{
    configAction.AddProfile(new AutoMapperProfile());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// map razor pages
app.MapRazorPages();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();



app.UseEndpoints(endPoints =>
{
    endPoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    endPoints.MapControllerRoute("Agreements", "Agreements", new { controller = "Agreements", action = "Index" });
});

app.Run();
