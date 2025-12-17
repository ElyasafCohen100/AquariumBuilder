
using System.Text.Json.Serialization;
using AquariumBuilder.Backend.Services.Aquarium;
using AquariumBuilder.Backend.Services.Interfaces;

namespace AquariumBuilder.Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddSwaggerGen();
            //builder.Services.AddControllers();

            builder.Services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(
                    new JsonStringEnumConverter()
                    );
                });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IAquariumService, AquariumService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
