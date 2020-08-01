using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dada.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Social()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}