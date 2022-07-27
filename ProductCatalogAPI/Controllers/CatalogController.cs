using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        public CatalogController(CatalogContext context)
        {

        }
        [HttpGet("[action")]
        public async Task<IActionResult> CatalogBrands()
        {

        }
    }
}
