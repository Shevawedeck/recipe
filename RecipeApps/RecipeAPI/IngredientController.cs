using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        [HttpGet]
        public List<BizIngredient> Get()
        {
            return new BizIngredient().GetList();
        }

    }
}
