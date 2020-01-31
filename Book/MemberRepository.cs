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

        public Member getMemberById(int id)
        {
            return members.FirstOrDefault(x => x.id.Equals(id));
        }
        public void addMember(Member m)
        {
            members.Add(m);
        }

    }
}
