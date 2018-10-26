using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Jason");
        }


        public string Index()
        {
            return "Hello";
        }
    }
}
