using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

ConfigSettings configSettings = new ConfigSettings();
DbContextConfiguration dbContextConfiguration = configSettings.DbContextConfiguration;

builder.Services.AddDbContext<ApplicationContext>( options => options.UseSqlServer( dbContextConfiguration.ConnectionString ) );
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmployee, EmployeeService>( provider => new EmployeeService( dbContextConfiguration.ConnectionString ) );
builder.Services.AddScoped<IOrder, OrderService>( provider => new OrderService( dbContextConfiguration.ConnectionString ) );
builder.Services.AddScoped<ISubdivision, SubdivisionService>( provider => new SubdivisionService( dbContextConfiguration.ConnectionString ) );
builder.Services.AddScoped<ITag, TagService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}" );

app.MapFallbackToFile( "index.html" ); ;

app.Run();
