using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Week_14_JWT.API.Data;
using Week_14_JWT.API.Dtos;
using Week_14_JWT.API.HelperFunctions;
using Week_14_JWT.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddLogging(configure => configure.AddConsole());

builder.Services.AddDbContext<Context>(opts =>
{
    opts.UseInMemoryDatabase("Week-14-JWT.API");
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

builder.Services.AddScoped<TokenService>();
builder.Services.Configure<CustomTokenOptions>(builder.Configuration.GetSection("TokenOptions"));


var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<CustomTokenOptions>();

builder.Services.AddAuthentication(opts =>
{
    opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidAudience = tokenOptions!.Audience[0],
            ValidIssuer = tokenOptions.Issuer,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey)),
            ClockSkew = TimeSpan.Zero
        };
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    // E�er bir database ile �al���yorsan�z projenizin runtime olma esnas�nda altta ki i�lemleri ger�ekle�tirebilirsiniz.
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();
    var db = services.GetRequiredService<Context>();
    try
	{
        /*await db.Database.MigrateAsync();*/ // migration i�lemi s�ras�nda migration olu�turduktan sonra update yapman�za gerek kalmaz. Bunu da ger�ek db lerde kullanabilirsiniz.
        var userManager = services.GetRequiredService<UserManager<User>>();
		var roleManager = services.GetRequiredService<RoleManager<Role>>();
		await IdentitySeed.SeedAsync(userManager, roleManager); // �rnek data olu�turdu�umuz s�n�f� �a��r�yoruz ve seed i�lemini ger�ekle�tiriyoruz.
        logger.LogInformation("Database migrated and seeded successfully...! You did congrats.!");
    }
	catch (Exception)
	{
		logger.LogError("An error occurred while migrating or seeding the database... Check your brain lol");
		//await db.Database.RollbackTransactionAsync(); // bir hata durumunda db de ki b�t�n i�lemleri geri al�r. In memory yani ram de db tutuyorsan bunu kullanamazs�n sadece ger�ek db lerde kullan�l�r.
        /*await db.Database.EnsureDeletedAsync();*/ // hata durumunda olu�an db yi siler. Bunu da ger�ek db ler de kullanabilirsiniz.
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
