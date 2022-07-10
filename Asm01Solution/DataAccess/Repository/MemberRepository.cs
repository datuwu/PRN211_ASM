using DataAccess;
using BusinessObject;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();
        public IEnumerable<Member> GetMembers1() => MemberDAO.Instance.GetMemberList1();

        public Member GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

<<<<<<< HEAD:Asm01Solution/DataAccess/Repository/MemberRepository.cs
        public IEnumerable<Member> SortDesc()=>MemberDAO.Instance.MemberListDesc();
        public bool Login(Member member) => MemberDAO.Instance.Login(member);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public Member GetMemberByIDAndName(int MemberID, string MemberName) => MemberDAO.Instance.GetMemberByIDAndName(MemberID, MemberName);
=======
        public IEnumerable<Member> SortDesc() => MemberDAO.Instance.MemberListDesc();
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public Member GetMemberByIDandName(int MemberID, string MemberName) => MemberDAO.Instance.GetMemberByIDandName(MemberID, MemberName);
        public IEnumerable<Member> GetCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);
>>>>>>> asm1_repo:Ass01Solution/DataAccess/Repository/MemberRepository.cs
    }
}
