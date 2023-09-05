using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarContracts_StudentName_LIB.Models;
namespace CarContracts_StudentName_LIB.Repo
{
    public interface IUsersRepo
    {
        User checkLogin(String username, String password);
    }
}
