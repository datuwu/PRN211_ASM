﻿using System.Data;
using BusinessObject;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
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
        public IEnumerable<Member> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID,MemberName,Email,Password,City,Country From FStore";
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public Member GetMemberByID(int MemberID)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country" + "From SolidStore where MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        member = new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

            return member;
        }
        public Member GetMemberByIDAndName(int MemberID,string MemberName)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelectIDandNAME = "Select MemberID,MemberName,Email,Password,City,Country" + "From SolidStore where MemberID=@MemberID AND MemberName=@MemberName";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberName", 50, MemberName, DbType.String));
                dataReader = dataProvider.GetDataReader(SQLSelectIDandNAME, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        member = new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

            return member;
        }
        public void AddNew(Member member)
        {
            try
            {
                Member pro = GetMemberByID(member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert FStore values(@MemberID,@MemberName,@Email,@Password,@City,@Country)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                CloseConnection();
            }
        }
        public void Update(Member member)
        {
            try
            {
                Member c = GetMemberByID(member.MemberID);
                if (c == null)
                {
                    string SQLUpdate = "Update FStore set MemberName=@MemberName,Email=@Email,Password=@Password,City=@City,Country=@Country where MemberID=@MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                CloseConnection();
            }

        }
        public void Remove(int MemberID)
        {
            try
            {
                Member member = GetMemberByID(MemberID);
                if (member != null)
                {
                    string SQLDelete = "Delete FStore where MemberID=@MemberID";
                    var parameters = dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters);
                }
                else
                {
                    throw new Exception("The car does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
         public IEnumerable<Member> MemberListDesc()
        {
            IDataReader dataReader = null;
            string SQLSortDesc = "Select MemberID,MemberName,Email,Password,City,Country From FStore ORDER BY MemberName DESC";
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSortDesc, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        public static Member readJSON()
        {
            /*
             được áp dụng cho một trường, phương thức hoặc thuộc tính của lớp 
            thì chúng không thể được truy cập từ đối tượng thể hiện của lớp, 
             */
            Member member = new Member();
            using (StreamReader sr = File.OpenText(@".\Repository\appsettings.json"))
            {
                var obj = sr.ReadToEnd();
                member = JsonConvert.DeserializeObject<Member>(obj);
            }
            return member;
        }

        public Member Login(string email, string password)
        {
            try
            {
                Member member_read = readJSON();
                if (
                    member_read.Password.Equals(password) && 
                    member_read.Email.Equals(email)
                    )
                {
                    return true;
                }

                else if (email == null || password == null || email == "" || password == "")
                {
                    return false;
                    throw new Exception("Login fail");
                }
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}

