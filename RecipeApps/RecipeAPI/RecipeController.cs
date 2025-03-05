using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List <BizRecipe> Get()
        {
            return new BizRecipe().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public BizRecipe Get(int id) 
        {
            BizRecipe r = new BizRecipe();
            r.Load(id);
            return r;
        }
        //[HttpGet("getbycookbook/{cookbookid:int:min(0)}")]
        //public List<BizRecipe> GetByCookbook(int cookbookid)
        //{
        //    return new BizRecipe().Search(cookbookid);
        //}
        [HttpGet("getbycookbook/{cookbookname}")]
        public List<BizRecipe> GetByCookbookName(string cookbookname)
        {
            return new BizRecipe().SearchByCookbook(cookbookname);
        }
        [HttpGet("getbycuisine/{cuisineid}")]
        public List<BizRecipe> GetByCuisineId(int cuisineid)
        {
            return new BizRecipe().SearchByCuisine(cuisineid);
        }
        [HttpPost]
        [AuthPermission(1)]
        public IActionResult Post(BizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(recipe);
            }
            catch (Exception ex)
            {
                recipe.ErrorMessage = ex.Message;
                return BadRequest(recipe);
            }
        }
        [HttpDelete]
        [AuthPermission(3)]
        public IActionResult Delete(int id)
        {
            BizRecipe r = new();
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
        [HttpGet("usernames")]
        public List<BizUsername> GetUsernames()
        {
            return new BizUsername().GetList();
        }
        [HttpGet("cuisines")]
        public List<BizCuisine> GetCuisines()
        {
            return new BizCuisine().GetList();
        }
    }
}
