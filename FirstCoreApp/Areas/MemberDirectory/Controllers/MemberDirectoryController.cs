using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.MemberDirectory.Services;
using FirstCoreApp.MemberDirectory.Models;

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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var member = _members.Get(id);

            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            else
            {
                if (member.MemberID == 0)
                    FirstCoreApp.Services.DataTier.ExecuteNonQuery("INSERT INTO MemberDirectory_Members (MemberFirstName,MemberLastName,MemberTitle) VALUES ({0},{1},{2})", member.FirstName, member.LastName, member.Title);
                else
                    FirstCoreApp.Services.DataTier.ExecuteNonQuery("UPDATE MemberDirectory_Members SET MemberFirstName = {0}, MemberLastName = {1}, MemberTitle = {2} WHERE MemberID = {3}", member.FirstName, member.LastName, member.Title, member.MemberID);
                return RedirectToAction("Index");
            }
                
        }
    }
}
