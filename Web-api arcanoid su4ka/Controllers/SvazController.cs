using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SvazController : Controller
    {
        private readonly ISvazkaInterface _svazkaInterface;

        public SvazController(ISvazkaInterface svazkaInterface)
        {
            _svazkaInterface = svazkaInterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetallSvazcontroller()
        {
            var wwwwwwwwww = await _svazkaInterface.GetallSvaz();
            return Ok(wwwwwwwwww);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSvazbyidcontroller(int id)
        {
            var aaaaaaaaaaaaa = _svazkaInterface.GetSvazbyId(id);
            if (aaaaaaaaaaaaa == null)
            {
                return NotFound();
            }
            return Ok(aaaaaaaaaaaaa);
        }

        [HttpPost]
        public async Task<IActionResult> PostNewsvazController(UserSkinSvaz userSkinSvaz)
        {
            var result = await _svazkaInterface.PostNewSvaz(userSkinSvaz);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> EditsvazController(int id, UserSkinSvaz userSkinSvaz)
        {
            if (id != userSkinSvaz.ID_Svaz)
            {
                return BadRequest();
            }
            var result = await _svazkaInterface.EditSvazbyid(userSkinSvaz);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSvazcontroller(int id)
        {
            var result = await _svazkaInterface.DeleteSvaz(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpGet("{userId}/skins/{ballId}")]
        public async Task<IActionResult> CheckSkinOwnership(int userId, int ballId)
        {
            bool hasSkin = await _svazkaInterface.HasSkinAsync(userId, ballId);

            if (hasSkin)
            {
                return Ok(new { hasSkin = true });
            }
            else
            {
                return Ok(new { hasSkin = false });
            }
        }
    }
}
