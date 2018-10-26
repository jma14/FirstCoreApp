using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.MemberDirectory.Models;

namespace FirstCoreApp.MemberDirectory.Services
{
    public interface IMembers
    {
        IEnumerable<Member> GetAll();
    }
}
