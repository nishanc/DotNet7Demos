using System.Threading.RateLimiting;
using DotNet7DemosWeb;
using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<WeatherService>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRateLimiter(new RateLimiterOptions{
    Limiter = PartitionedRateLimiter.Create<HttpContext, string>(context => 
    {
        return RateLimitPartition.CreateConcurrencyLimiter("ConcurrentRequestLimiter",
            _ => new ConcurrencyLimiterOptions(1, QueueProcessingOrder.NewestFirst, 0));
    })
});

app.MapControllers();

app.Run();
