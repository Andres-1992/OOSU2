using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class MemberRepository
    {
       private List<Member> members = new List<Member>();

        internal Member GetMemberById(int id)
        {
            return members.FirstOrDefault(x => x.Id.Equals(id));
        }
        internal void AddMember(Member m)
        {
            members.Add(m);
        }
        internal void LoadMembers()
        {
            Member mem = new Member(1, "Lois Haas", "07355521", "Lois.Haas@student.hb.se");
            Member mem1 = new Member(2, "Iona Moran", "07055552", "Iona.Moran@student.hb.se");
            Member mem2 = new Member(3, "Sophia Riggs", "07555531", "Sophia.Riggs@student.hb.se");
            Member mem3 = new Member(4, "Betty Alexander", "07655514", "Betty.Alexander@student.hb.se");
           AddMember(mem);
           AddMember(mem1);
           AddMember(mem2);
           AddMember(mem3);
        }

    }
}
