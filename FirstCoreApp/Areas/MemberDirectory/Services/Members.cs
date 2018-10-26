using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.MemberDirectory.Models;
using FirstCoreApp.Services;

namespace FirstCoreApp.MemberDirectory.Services
{
    public class Members : IMembers
    {
        private List<Member> _members;

        public Members()
        {
            DataTable dt = DataTier.GetDataTable("SELECT * FROM MemberDirectory_Members");
            _members = new List<Member>();

            foreach (DataRow row in dt.Rows)
            {
                _members.Add(new Member
                {
                    MemberID = (int)row["MemberID"],
                    FirstName = row["MemberFirstName"].ToString(),
                    LastName = row["MemberLastName"].ToString(),
                    Title = row["MemberTitle"].ToString()
                });
            }
        }
        public IEnumerable<Member> GetAll()
        {
            return _members;
        }
    }
}
