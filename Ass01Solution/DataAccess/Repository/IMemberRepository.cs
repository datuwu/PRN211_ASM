using BusinessObject;
using System.Collections;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetNameByID(int id);
        void DeleteMember(int id);
        void InsertMember(Member member); 
        void UpdateMember(Member member);
    }
}
