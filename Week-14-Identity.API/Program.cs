using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Week_14_Identity.API.Data;
using Week_14_Identity.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddLogging(configure => configure.AddConsole());

builder.Services.AddDbContext<Context>(opts =>
{
    opts.UseInMemoryDatabase("Week-14-Identity.API");
});

builder.Services.AddIdentity<User, Role>(opts =>
{
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequireDigit = true;
    opts.Password.RequireLowercase = true;
    opts.Password.RequireUppercase = true;
    opts.Password.RequireNonAlphanumeric = true;
    opts.Password.RequiredLength = 8;
})
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    // Eðer bir database ile çalýþýyorsanýz projenizin runtime olma esnasýnda altta ki iþlemleri gerçekleþtirebilirsiniz.
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();
    var db = services.GetRequiredService<Context>();
    try
	{
        /*await db.Database.MigrateAsync();*/ // migration iþlemi sýrasýnda migration oluþturduktan sonra update yapmanýza gerek kalmaz. Bunu da gerçek db lerde kullanabilirsiniz.
        var userManager = services.GetRequiredService<UserManager<User>>();
		var roleManager = services.GetRequiredService<RoleManager<Role>>();
		await IdentitySeed.SeedAsync(userManager, roleManager); // Örnek data oluþturduðumuz sýnýfý çaðýrýyoruz ve seed iþlemini gerçekleþtiriyoruz.
        logger.LogInformation("Database migrated and seeded successfully...! You did congrats.!");
    }
	catch (Exception)
	{
		logger.LogError("An error occurred while migrating or seeding the database... Check your brain lol");
		//await db.Database.RollbackTransactionAsync(); // bir hata durumunda db de ki bütün iþlemleri geri alýr. In memory yani ram de db tutuyorsan bunu kullanamazsýn sadece gerçek db lerde kullanýlýr.
        /*await db.Database.EnsureDeletedAsync();*/ // hata durumunda oluþan db yi siler. Bunu da gerçek db ler de kullanabilirsiniz.
        throw;
	}

}

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
