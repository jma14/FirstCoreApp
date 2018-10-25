using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    [Route("company/[controller]")]
    public class EmployeeController : Controller
    {
        [Route("[action]")]
        public ContentResult Name()
        {
            return Content("Jason");
        }

        [Route("")]
        [Route("[action]")]
        public string Index()
        {
            return "Hello";
        }
    }
}
