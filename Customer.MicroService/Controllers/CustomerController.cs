using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        public CustomerController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Hello Customer";
        }
    }
}