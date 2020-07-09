using System;
using Microsoft.AspNetCore.Mvc;
using WebApiSelfHosted.Services;

namespace WebApiSelfHosted.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_helloService.GetMessage());
        }
    }
}
