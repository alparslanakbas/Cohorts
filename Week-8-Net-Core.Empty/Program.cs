using Microsoft.AspNetCore.Mvc;

// buradaki program cs asl�nda bir IoC container'd�r. Bu container'da servislerin tan�mlanmas� ve kullan�lmas� sa�lan�r.
// ayr�ca uygulamalar�m�z daki ba��ml�l�klar�n y�netilmesi sa�lan�r yani DI i�lemleri burada yap�l�r.

// Builder taraf�nda uygulamada ki yap�land�rmalar yap�l�r. servisi, configrasyonlar vb..
var builder = WebApplication.CreateBuilder(args);

// Add controllers and views
builder.Services.AddControllersWithViews();
// add mvc
builder.Services.AddMvc();


// burdan sonra ki k�s�mlar da uygulama build edildikten sonra �al��acak olan k�s�mlard�r.
// middlewareler burada tan�mlan�r.
// isteklerin y�nlendirilmesi, yetkilendirilmesi, statik dosyalar�n kullan�lmas� gibi i�lemler burada yap�l�r.
var app = builder.Build();

// Bu alanda �o�unlukla middleware'ler tan�mlan�r 
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();



// Minimal api ufak projeler i�in idealdir. alta ekstra �rnek bir minimal api kullan�m� b�rakt�m.
// GET
app.MapGet("/GetUserInfo/{id}", (int id, ILogger<Program> logger) =>
{
    var response = new UserLoginResponseModel
    {
        Success = true,
        UserEmail = "alparslan@gmail.com"
    };
    logger.LogInformation("User info is requested");
    return Results.Ok(response);
})
.WithName("GetUserInfo");

// POST
app.MapPost("/Login", ([FromBody] UserLoginRequestModel request) =>
{
    var response = new UserLoginResponseModel
    {
        Success = true,
        UserEmail = "alparslan@gmail.com"
    };
    return Results.Ok(response);
})
.WithName("Login");

// add map controller route yani anasayfa i�in varsay�lan route.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



internal class UserLoginRequestModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}

internal class UserLoginResponseModel
{
    public bool Success { get; set; }
    public string UserEmail { get; set; }
}
