using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IMemberRepository
    {
        //CRUD: Create, Read, Update, Delete
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int id);
        void AddNew(Member member);
        void Update(Member member);
        void Remove(int id);
    }
}
