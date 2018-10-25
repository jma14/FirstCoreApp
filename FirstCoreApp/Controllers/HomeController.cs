using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Services;

namespace FirstCoreApp.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private IVideoData _videos;
        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        [Route("")]
        public ViewResult Index()
        {
            var model = _videos.GetAll();
            return View(model);
        }
    }
}
