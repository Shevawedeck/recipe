using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<BizCookbook> Get()
        {
            return new BizCookbook().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public BizCookbook Get(int id)
        {
            BizCookbook c = new BizCookbook();
            c.Load(id);
            return c;
        }
    }
}
