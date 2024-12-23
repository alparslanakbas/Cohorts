using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Week_14_Identity.API.Dtos;
using Week_14_Identity.API.Models;

namespace Week_14_Identity.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInManager;
        readonly ILogger<AuthController> _logger;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }


        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Register register)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        _logger.LogError(error.ErrorMessage);
                    }
                }
            }

            else
            {
                var user = new User
                {
                    UserName = register.UserName,
                    Email = register.Email
                };

                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    return Ok(user);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    _logger.LogError(error.Description);
                }
                _logger.LogError("User not created");
                return BadRequest();

            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var user = await _userManager.FindByEmailAsync(login.Email);

            if (user is null)
            {
                _logger.LogError("User not found");
                return BadRequest();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password, false);
            if (result.Succeeded) 
            {
                _logger.LogInformation("User logged in");
                return Ok(user);
            }
            else
            {
                _logger.LogError("User not logged in");
                return BadRequest();
            }

        }
    }
 }
