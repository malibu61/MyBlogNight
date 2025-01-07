using FluentValidation.AspNetCore;
using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.BusinessLayer.Concrete;
using MyBlogNight2.BusinessLayer.Container;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Context;
using MyBlogNight2.DataAccessLayer.EntityFramework;
using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BlogContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BlogContext>().AddErrorDescriber<CustomIdentityErrorValidator>();

builder.Services.ContainerDependencies();

builder.Services.AddControllersWithViews().AddFluentValidation();

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
app.UseAuthentication();        //Login olmak için kullanýlýr
app.UseAuthorization();         //Bir sayfaya eriþilip eriþilemeyeceðini belirleyen karar yapýsý

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

    );
});

app.Run();
