﻿using BusinessObject;
using System.Collections;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int id);
        void DeleteMember(int id);
        Member Login(string email, string password);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        IEnumerable<Member> SortDesc();
        Member GetMemberByIDAndName(int id, string name);
    }
}
