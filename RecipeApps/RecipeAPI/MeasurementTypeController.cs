using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementTypeController : ControllerBase
    {
        [HttpGet]
        public List<BizMeasurementType> Get()
        {
            return new BizMeasurementType().GetList();
        }
    }
}
