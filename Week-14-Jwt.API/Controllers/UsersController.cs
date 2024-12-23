using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week_14_JWT.API.Data;
using Week_14_JWT.API.Models;


namespace Week_14_JWT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        readonly Context _context;
        readonly ILogger<UsersController> _logger;

        public UsersController(Context context, ILogger<UsersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync();
                _logger.LogInformation("User {0} is requesting all users", user!.UserName);

                if (user is null)
                {
                    _logger.LogError("User {0} is not found", user!.UserName);
                    return NotFound();
                }

                return await _context.Users.ToListAsync();
            }
            catch (UnauthorizedAccessException)
            {
                _logger.LogError("Unauthorized access");
                throw;
            }
        }
    }
}
