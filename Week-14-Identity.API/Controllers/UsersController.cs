using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week_14_Identity.API.Data;
using Week_14_Identity.API.Models;

namespace Week_14_Identity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Context _context;

        public UsersController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
