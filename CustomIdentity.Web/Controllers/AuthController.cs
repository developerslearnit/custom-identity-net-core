using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentity.Web.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("login")]
        public IActionResult login()
        {
            return View();
        }
    }
}
