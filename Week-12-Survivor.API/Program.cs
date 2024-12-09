using Microsoft.EntityFrameworkCore;
using Week_12_Survivor.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<Context>(options =>
{
    options.UseInMemoryDatabase("SurvivorsDb");
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
	try
	{
        var services = scope.ServiceProvider;

        var db = services.GetRequiredService<Context>();
        Seed.SeedData(db);

    }
	catch (Exception ex)
	{
        Console.WriteLine($"Hata: {ex}");
	}
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
