using Microsoft.AspNetCore.Mvc;

using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectionController: ControllerBase
    {
        [HttpGet]
        public List<BizDirection> Get()
        {
            return new BizDirection().GetList();
        }

        [HttpGet("{id:int:min(0)}")]
        public BizDirection Get(int id)
        {
            BizDirection d = new BizDirection();
            d.Load(id);
            return d;
        }
        [HttpPost]
        public IActionResult Post(BizDirection Direction)
        {
            try
            {
                Direction.Save();
                return Ok(Direction);
            }
            catch (Exception ex)
            {
                Direction.ErrorMessage = ex.Message;
                return BadRequest(Direction);
            }

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            BizDirection d = new();
            try
            {
                d.Delete(id);
                return Ok(d);
            }
            catch (Exception ex)
            {
                d.ErrorMessage = ex.Message;
                return BadRequest(d);
            }

        }
        [HttpGet("getbyrecipe/{recipeid:int:min(0)}")]
        public List<BizDirection> GetByRecipe(int recipeid)
        {
            return new BizDirection().LoadByRecipeId(recipeid);
        }
    }
}
