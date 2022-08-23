using BasicCrud.Model;
using BasicCrud.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicCrud.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
   // [ApiVersion("1.0")]
   // [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : Controller
    {
        private readonly IUsers _iuser;
        public UserController(IUsers iuser)
        {
            _iuser = iuser;
        }

        [HttpPost("Adduser")]

        public async Task<IActionResult> Adduser(User user)
        {

            if (ModelState.IsValid)
            {
                var creat = await _iuser.CreateUser(user);
                if (creat != null)
                {
                   // return Ok(creat);
                    return CreatedAtAction("Getuser", new { id = creat.Id }, creat);
                }
                else
                {
                    return BadRequest("Not Created");
                }

            }
            else
            {

                return BadRequest("Model not properly filled");
            }
        }

       // [HttpGet("Getuser")]
        [HttpGet("{id}")]
        public async Task<User> Getuser(string id)
        {

            var eistx = await _iuser.GetUser(id);
            if (eistx != null)
            {
                return eistx;
            }
            else
            {
                return null;
            }
        }

        [HttpGet("GetAllUser")]
        // public async Task<IEnumerable<Faculty>> GetAllFaculty()
        public async Task<IEnumerable<User>> GetAllUser()
        {

            var eistx = await _iuser.GetAllUsers();

            return eistx;
            
        }
    }
}
