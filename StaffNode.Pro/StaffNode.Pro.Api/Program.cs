
using Microsoft.EntityFrameworkCore;
using StaffNode.Pro.Api.Database;
using StaffNode.Pro.Api.Routes;
using StaffNode.Pro.Application.Contracts.Persistence;
using StaffNode.Pro.Persistence.DatabaseContext;
using StaffNode.Pro.Persistence.Repos;

namespace StaffNode.Pro.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            var dbSettings = builder.Configuration.GetSection("DbSettings").Get<DBSettings>();
            builder.Services.Configure<DBSettings>(builder.Configuration.GetSection("DbSettings"));

            builder.Services.AddDbContext<StaffNodeProDatabaseContext>(options => 
            options.UseMongoDB(dbSettings?.Uri ?? string.Empty, dbSettings?.DatabaseName ?? string.Empty));

            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            var db = app.Services.CreateScope().ServiceProvider.GetRequiredService<StaffNodeProDatabaseContext>();
            db.Database.EnsureCreated();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            #region Boiler plate code

            //var summaries = new[]
            //{
            //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            //};

            //app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            //{
            //    var forecast = Enumerable.Range(1, 5).Select(index =>
            //        new WeatherForecast
            //        {
            //            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //            TemperatureC = Random.Shared.Next(-20, 55),
            //            Summary = summaries[Random.Shared.Next(summaries.Length)]
            //        })
            //        .ToArray();
            //    return forecast;
            //})
            //.WithName("GetWeatherForecast");

            #endregion

            // Application api routes
            app.MapContactRoutes();
            app.MapEmployeeRoutes();
            app.MapProfileRoutes();

            app.Run();
        }
    }
}
