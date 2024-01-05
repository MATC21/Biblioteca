using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;
using SistemBiblioteca.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddDbContext<LibreriaContext>(context =>
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("CADENASQL"));
});

builder.Services.AddScoped<IServicioAutor,ServicioAutor>();
builder.Services.AddScoped<IServicioCategoria,ServicioCategoria>();
builder.Services.AddScoped<IServicioUsuario,ServicioUsuario>();
builder.Services.AddScoped<IServicioLista,ServicioLista>();

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
