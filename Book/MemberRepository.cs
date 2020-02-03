using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class MemberRepository
    {
        List<Member> members = new List<Member>();

        public Member GetMemberById(int id)
        {
            return members.FirstOrDefault(x => x.Id.Equals(id));
        }
        public void AddMember(Member m)
        {
            members.Add(m);
        }

    }
}
