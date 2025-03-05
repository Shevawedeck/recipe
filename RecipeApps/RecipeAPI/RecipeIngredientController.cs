using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeIngredientController : ControllerBase
    {
        [HttpGet]
        public List<BizRecipeIngredient> Get()
        {
            return new BizRecipeIngredient().GetList();
        }

        //[HttpGet("{id:int:min(0)}")]
        //public BizRecipeIngredient Get(int recipeid)
        //{
        //    BizRecipe r = new BizRecipe();
        //    i.Load(id);
        //    return i;
        //}



        [HttpGet("getbyrecipe/{recipeid:int:min(0)}")]
        public List<BizRecipeIngredient> GetByRecipe(int recipeid)
        {
            return new BizRecipeIngredient().LoadByRecipeId(recipeid);
        }

        [HttpPost]
        [AuthPermission(1)]
        public IActionResult Post(BizRecipeIngredient RecipeIngredient)
        {
            try
            {
                RecipeIngredient.Save();
                return Ok(RecipeIngredient);
            }
            catch (Exception ex)
            {
                RecipeIngredient.ErrorMessage = ex.Message;
                return BadRequest(RecipeIngredient);
            }
        }
        [HttpDelete]
        [AuthPermission(1)]
        public IActionResult Delete(int id)
        {
            BizRecipeIngredient r = new();
            try
            {
                r.Delete(id);
                return Ok(r);
            }
            catch (Exception ex)
            {
                r.ErrorMessage = ex.Message;
                return BadRequest(r);
            }
        }
        [HttpGet("ingredients")]
        public List<BizIngredient> GetIngredients()
        {
            return new BizIngredient().GetList(true);
        }
    }
}
