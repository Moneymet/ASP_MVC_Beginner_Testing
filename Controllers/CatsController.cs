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
            var cat = new Cat(){id=1, lifetimeJumps=2100};
            return View(cat);
        }

        public ActionResult Birthed(int year, int month){
            return Content("Year: " + year + "\nMonth: " + month);
        }

        public ActionResult Edit(int Id, int LifetimeJumps){
            //Id = 5;
            return Content("ID: " + Id + "\nLifetime jumps: " + LifetimeJumps);
        }
        
    }
}
