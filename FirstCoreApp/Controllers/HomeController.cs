using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Services;

namespace FirstCoreApp.Controllers
{
    
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
