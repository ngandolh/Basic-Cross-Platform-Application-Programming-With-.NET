using CarContracts_StudentName_LIB.Models;
using PRN211PE_SU22_StudentFullName.Repo.DAO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarContracts_StudentName_LIB.Repo
{
    public  class UsersRepo : IUsersRepo
    {
        

        User IUsersRepo.checkLogin(string username, string password) => UsersDAO.Instance.CheckLogin(username, password);
    }
}
