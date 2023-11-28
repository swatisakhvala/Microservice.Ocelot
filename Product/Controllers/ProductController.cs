using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        public ProductController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Hello Product";
        }
    }
}