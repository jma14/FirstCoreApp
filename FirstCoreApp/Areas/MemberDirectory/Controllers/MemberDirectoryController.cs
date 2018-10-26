using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.MemberDirectory.Services;

namespace FirstCoreApp.MemberDirectory.Controllers
{
    [Area("MemberDirectory")]
    public class MemberDirectoryController : Controller
    {
        private IMembers _members;
        public MemberDirectoryController(IMembers members)
        {
            _members = members;
        }

        public IActionResult Index()
        {
            var model = _members.GetAll();
            return View(model);
        }
    }
}
