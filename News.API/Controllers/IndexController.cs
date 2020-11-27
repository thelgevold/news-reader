using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace News.API.Controllers
{
    [Route("")]
    public class IndexController : Controller
    {
        [Route("{*url}")]
        public IActionResult Index()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "News.Api/api.exe/index.html");

            return File("~/index.html", "text/html");
        }
    } 
} 
