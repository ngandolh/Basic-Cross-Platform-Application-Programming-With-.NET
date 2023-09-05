using CarContracts_StudentName_LIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarContracts_StudentName_LIB.DAO;
namespace CarContracts_StudentName_LIB.Repo
{
    public class ContactRepo : IContactRepo
    {
        public void add(Contract customerAccount) => ContractDAO.Instance.add(customerAccount);

        public List<Contract> getAll() => ContractDAO.Instance.getAll();

        public List<Contract> getAllCus() => ContractDAO.Instance.getAll();

        public List<Contract> getByRegion(string region) => ContractDAO.Instance.getByRegion(region);

        public Contract getCus(int id) => ContractDAO.Instance.get(id);

        public void remove(int AccountID) => ContractDAO.Instance.delete(AccountID);

        public void update(Contract customerAccount) => ContractDAO.Instance.update(customerAccount);
    }
}
