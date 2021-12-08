using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_MVC_Beginner_Testing.Models;

namespace ASP_MVC_Beginner_Testing.Controllers
{
    public class CatsController : Controller
    {
        public ActionResult Random(){
            var cat = new Cat(){Id=1, LifetimeJumps=2100};
            return View(cat);
        }
    }
}
