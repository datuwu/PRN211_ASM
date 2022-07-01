using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddNew(Member member) => MemberDAO.Instance.AddNewMember(member);

        public Member GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void Remove(int id) => MemberDAO.Instance.RemoveMember(id);

        public void Update(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
