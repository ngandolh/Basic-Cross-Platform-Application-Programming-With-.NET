using CarContracts_StudentName_LIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211PE_SU22_StudentFullName.Repo.DAO
{
    public class UsersDAO
    {
        private UsersDAO() { }
        private static UsersDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UsersDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UsersDAO();
                    }
                    return instance;
                }
            }
        }
        public User CheckLogin(string userName, string password)
        {
            User result = null;
            CarContractsDbContext DbContext = new CarContractsDbContext();
            var member = DbContext.Users
                    .Where(b => b.UserName == userName)
                    .FirstOrDefault();
            if (member == null)
            {
                throw new Exception("User name does not existed!");
            }
            else
            {
                if (member.Password != password)
                {
                    throw new Exception("Password does not correct!");
                }
                else { result = member; }
            }
            return result;
        }
    }
}
