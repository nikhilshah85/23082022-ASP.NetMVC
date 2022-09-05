using IdentityFramework.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication().AddFacebook(config =>
{
    config.AppId = "323449612916418";
    config.AppSecret = "18fa8bbb678ec06efc32739c6c4864e0";

});

builder.Services.AddAuthentication().AddGoogle(config =>
{
    config.ClientId = "20394732975825894259724";
    config.ClientSecret = "fmnddsgjkngjfdgjdfngmfngmdfngkdjlfngljdfksg";

});

builder.Services.AddAuthentication().AddTwitter(config =>
{
    config.ConsumerKey = "20394732975825894259724";
    config.ConsumerSecret = "fmnddsgjkngjfdgjdfngmfngmdfngkdjlfngljdfksg";

});

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
