using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserInterface _userInterface;

        public UserController(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersControllermeth()
        {
            var wwwwwwwwww = await _userInterface.GetallUsers();
            return Ok(wwwwwwwwww);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersbyidController(int id)
        {
            var aaaaaaaaaaaaa = _userInterface.Getuserbyid(id);
            if (aaaaaaaaaaaaa == null)
            {
                return NotFound();
            }
            return Ok(aaaaaaaaaaaaa);
        }

        [HttpPost]
        public async Task<IActionResult> PostUserController(Usermodel usermodel)
        {
            var result = await _userInterface.PostNewUser(usermodel);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> EditUserController(int id, Usermodel usermodel)
        {
            if (id != usermodel.Id_user)
            {
                return BadRequest();
            }
            var result = await _userInterface.Edituserbyid(usermodel);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userInterface.DeleteUser(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
