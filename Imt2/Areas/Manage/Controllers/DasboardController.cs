using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imt2.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
