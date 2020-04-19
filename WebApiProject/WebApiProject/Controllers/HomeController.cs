using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Corriendo HomeController ..";
        }
    }
}
