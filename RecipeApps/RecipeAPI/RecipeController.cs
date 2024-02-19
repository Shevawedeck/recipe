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
    }
}
