using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleProject.Controllers
{
    public class PersonsController : Controller
    {       
        [Route("person/index")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
