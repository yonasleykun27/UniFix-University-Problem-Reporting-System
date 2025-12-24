using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniFix.Data;

namespace UniFix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User user)
        {
            if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            {
                return BadRequest("Username already exists");
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Register), new { id = user.Id }, user);
        }


        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(LoginRequest req)
        {

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == req.Username && u.Password == req.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Credentials"); 
            }

            if (user.IsBanned)
            {
                return BadRequest("Account is Banned"); 
            }

            return user;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }


        [HttpPut("warn/{id}")]
        public async Task<IActionResult> WarnUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            user.Warnings++;
            if (user.Warnings >= 3)
            {
                user.IsBanned = true;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

    
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}