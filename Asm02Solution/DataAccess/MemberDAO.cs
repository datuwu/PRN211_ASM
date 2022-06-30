using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;
public class MemberDAO
{
    //Using Singleton Pattern
    private static MemberDAO instance = null;
    private static readonly object instanceLock = new object();
    private MemberDAO() { }
    public static MemberDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
    }
    //Get List of Member
    public List<Member> GetMemberList()
    {
        List<Member> membersList;
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            membersList = fStoreContext.Members.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return membersList;    
    }
    //----------------------------------------------------------------
    //Get Member by ID
    public Member GetMemberByID(int memberId)
    {
        List<Member> membersList = GetMemberList();
        Member member = membersList.SingleOrDefault(m => m.MemberId == memberId);
        return member;
    }
    //----------------------------------------------------------------
    //Add a new Member
    public void AddNewMember (Member member)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext ();
            fStoreContext.Members.Add(member);
            fStoreContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Update a new Member
    public void UpdateMember(Member member)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            fStoreContext.Entry<Member>(member).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            fStoreContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Remove a member
    public void RemoveMember(int memberId)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            var member = fStoreContext.Members.SingleOrDefault(m => m.MemberId == memberId);
            fStoreContext.Members.Remove(member);
            fStoreContext.SaveChanges();
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }




}
