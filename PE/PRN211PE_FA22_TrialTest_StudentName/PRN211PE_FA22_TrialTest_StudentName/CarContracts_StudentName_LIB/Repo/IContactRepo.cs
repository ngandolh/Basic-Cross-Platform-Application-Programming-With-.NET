using CarContracts_StudentName_LIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarContracts_StudentName_LIB.Repo
{
    public interface IContactRepo
    {
        List<Contract> getAll();
        List<Contract> getByRegion(String region);
        Contract getCus(int id);
        void add(Contract customerAccount);
        void remove(int id);
        void update(Contract customerAccount);
        List<Contract> getAllCus();
    }
}
