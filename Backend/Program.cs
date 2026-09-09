using Backend.Clients;
using Backend.Clients.Interfaces;
using Backend.Middleware;
using Backend.Repositories;
using Backend.Repositories.Intrerfaces;
using Backend.Services;
using Backend.Services.Interfaces;
class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllers();
        builder.Services.AddHttpClient<ICatFactApiClient, CatFactApiClient>();
        builder.Services.AddScoped<ICatFactService, CatFactService>();
        builder.Services.AddScoped<ICatFactRepository, CatFactRepository>();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(
                name: "DevCORS",
                policy =>
                {
                    policy.WithOrigins("*");
                });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseCors("DevCORS");
        }

        app.UseMiddleware<ExceptionHandlerMiddleware>();
        app.MapControllers();
        app.UseHttpsRedirection();

        app.Run();

    }
}