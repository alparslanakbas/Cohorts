using Microsoft.AspNetCore.Identity;
using Week_14_JWT.API.Models;

namespace Week_14_JWT.API.Data
{
    public static class IdentitySeed
    {
        public static async Task SeedAsync(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            var roles = new[]
            {
                new Role { Name = "Admin" },
                new Role { Name = "User" }
            };

            foreach(var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role.Name!))
                    await roleManager.CreateAsync(role);
            }

            var adminUser = new User
            {
                Id = Guid.NewGuid(),
                UserName = "Alparslan",
                Email = "admin@gmail.com"
            };

            if(await userManager.FindByEmailAsync(adminUser.Email) is null)
            {
                var result = await userManager.CreateAsync(adminUser, "A.lparslan123");

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(adminUser, "Admin");

            }
        }
    }
}
