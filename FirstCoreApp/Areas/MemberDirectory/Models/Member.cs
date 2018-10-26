using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.MemberDirectory.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}
