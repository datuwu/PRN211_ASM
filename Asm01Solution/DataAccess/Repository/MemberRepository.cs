using DataAccess;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public Member GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public IEnumerable<Member> SortDesc()=>MemberDAO.Instance.MemberListDesc();
        public bool Login(Member member) => MemberDAO.Instance.Login(member);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public Member GetMemberByIDAndName(int MemberID, string MemberName) => MemberDAO.Instance.GetMemberByIDAndName(MemberID, MemberName);
    }
}
