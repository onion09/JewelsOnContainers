using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ProductCatalogAPI.Controllers
{
    //attributes-a special metadata on top of the class -- this is a API Controller
    //Route: how you need a url to get there api/Pic
    [Route("api/[controller]")]
    [ApiController]
    public class PicController : ControllerBase
    {
        
        private readonly IWebHostEnvironment _env;

        // dependency injection
        // when want anything to be injected to => cnostructor accepts parameter
        //on startup.cs services.AddControllers() will go through controllers to meet their needs 
        // and pass the host location to environment here
        public PicController(IWebHostEnvironment env)
        {
            _env = env;
        }

        //[Route("getimage/{id}/{name}")]
        [Route("{id}")]
        public IActionResult GetImage(int id)
        {
            
            var webRoot = _env.WebRootPath;
            var path = Path.Combine($"{webRoot}/Pics/", $"Ring{id}.jpg");
            var buffer = System.IO.File.ReadAllBytes(path);
            return File(buffer, "image/jpeg");
        }

    }
}
