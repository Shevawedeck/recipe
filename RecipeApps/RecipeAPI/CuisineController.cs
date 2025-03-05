using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        [HttpGet]
        public List<BizCuisine> Get()
        {
            return new BizCuisine().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public BizCuisine Get(int id)
        {
            BizCuisine c = new BizCuisine();
            c.Load(id);
            return c;
        }
        [HttpPost]
        [AuthPermission(1)]
        public IActionResult Post(BizCuisine cuisine)
        {
            try
            {
                cuisine.Save();
                return Ok(cuisine);
            }
            catch (Exception ex)
            {
                cuisine.ErrorMessage = ex.Message;
                return BadRequest(cuisine);
            }
        }
        [HttpDelete]
        [AuthPermission(3)]
        public IActionResult Delete(int id)
        {
            BizCuisine c = new();
            try
            {
                c.Delete(id);
                return Ok(c);
            }
            catch (Exception ex)
            {
                c.ErrorMessage = ex.Message;
                return BadRequest(c);
            }
        }
    }
}
