using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Controllers
{
    //ФЛАЛФЫЛАОФЫАоф
    [Route("api/[controller]")]
    [ApiController]
    public class SkinController : Controller
    {
        private readonly ISkinInterface _skinInterface;

        public SkinController(ISkinInterface skininterface)
        {
            _skinInterface = skininterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllskins()
        {
            var wwwwwwwwww = await _skinInterface.GetAllskins();
            return Ok(wwwwwwwwww);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkinbyIdcontroller(int id)
        {
            var aaaaaaaaaaaaa = _skinInterface.Getskinbyid(id);
            if (aaaaaaaaaaaaa == null)
            {
                return NotFound();
            }
            return Ok(aaaaaaaaaaaaa);
        }

        [HttpPost]
        public async Task<IActionResult> PostskinController(Skinmodel skinmodel)
        {
            var result = await _skinInterface.PostNewSkin(skinmodel);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> EditSkinbyIdcontroller(int id, Skinmodel skinmodel)
        {
            if (id != skinmodel.ID_Skin)
            {
                return BadRequest();
            }
            var result = await _skinInterface.Editskinbyid(skinmodel);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSkinController(int id)
        {
            var result = await _skinInterface.DeleteSkin(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
