using BusinessObject;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int id);
        void DeleteMember(int id);
        IEnumerable<Member> GetMembers1();
        void InsertMember(Member member);
        void UpdateMember(Member member);
        IEnumerable<Member> SortDesc();
<<<<<<< HEAD:Asm01Solution/DataAccess/Repository/IMemberRepository.cs
        Member GetMemberByIDAndName(int id, string name);
=======
        Member GetMemberByIDandName(int id, string name);
        IEnumerable<Member> GetCityAndCountry(string city, string country);
>>>>>>> asm1_repo:Ass01Solution/DataAccess/Repository/IMemberRepository.cs
    }
}

