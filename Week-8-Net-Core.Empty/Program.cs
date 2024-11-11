using Microsoft.AspNetCore.Mvc;

// buradaki program cs aslýnda bir IoC container'dýr. Bu container'da servislerin tanýmlanmasý ve kullanýlmasý saðlanýr.
// ayrýca uygulamalarýmýz daki baðýmlýlýklarýn yönetilmesi saðlanýr yani DI iþlemleri burada yapýlýr.

// Builder tarafýnda uygulamada ki yapýlandýrmalar yapýlýr. servisi, configrasyonlar vb..
var builder = WebApplication.CreateBuilder(args);

// Add controllers and views
builder.Services.AddControllersWithViews();
// add mvc
builder.Services.AddMvc();


// burdan sonra ki kýsýmlar da uygulama build edildikten sonra çalýþacak olan kýsýmlardýr.
// middlewareler burada tanýmlanýr.
// isteklerin yönlendirilmesi, yetkilendirilmesi, statik dosyalarýn kullanýlmasý gibi iþlemler burada yapýlýr.
var app = builder.Build();

// Bu alanda çoðunlukla middleware'ler tanýmlanýr 
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();



// Minimal api ufak projeler için idealdir. alta ekstra örnek bir minimal api kullanýmý býraktým.
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

// add map controller route yani anasayfa için varsayýlan route.
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
