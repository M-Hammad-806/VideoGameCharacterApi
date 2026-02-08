using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using VideoGameCharacterApi.Data;
using VideoGameCharacterApi.Services;
namespace VideoGameCharacterApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
<<<<<<< HEAD
=======
            builder.Services.AddDbContext<AppDbContext>
                (options => options.UseSqlServer(
                    builder
                .Configuration.GetConnectionString("DefaultConnection")));
>>>>>>> 3572169 (sqlserver_Configured)

            builder.Services.AddScoped<IVideoGameCharacteService, VideoGameCharacterService>();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
