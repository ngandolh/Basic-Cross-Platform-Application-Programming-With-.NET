using CarContracts_StudentName_LIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarContracts_StudentName_LIB.DAO
{
    public class ContractDAO
    {
        
            private ContractDAO() { }
            private static ContractDAO instance = null;
            private static readonly object instanceLock = new();

            public static ContractDAO Instance
            {
                get
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new ContractDAO();
                        }
                        return instance;
                    }
                }
            }
        public List<Contract> getByRegion(String region)
        {
            List<Contract> listProducts = new List<Contract>();
            try
            {
                CarContractsDbContext DbContext = new CarContractsDbContext();
                listProducts = DbContext.Contracts
                        .Where(a => a.ContractCode.Contains(region))
                        .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Get list by region fail");
            }
            return listProducts;
        }
        public List<Contract> getAll()
            {
                List<Contract> list = new List<Contract>();
                try
                {
                    CarContractsDbContext DbContext = new CarContractsDbContext();
                    list = DbContext.Contracts.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Get list fail");
                }
                return list;
            }
            //public List<Contract> getAllCuss()
            //{
            //    List<Customer> list = new List<Customer>();
            //    try
            //    {
            //        CarContractsDbContext DbContext = new CarContractsDbContext();
            //        list = DbContext.Customers.ToList();
            //    }
            //    catch (Exception)
            //    {
            //        throw new Exception("Get list fail");
            //    }
            //    return list;
            //}
            public void add(Contract a)
            {
                try
                {
                    CarContractsDbContext DbContext = new CarContractsDbContext();
                    DbContext.Contracts.Add(a);
                    DbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Create  fail");
                }
            }
            public void update(Contract a)
            {
                try
                {
                    CarContractsDbContext DbContext = new CarContractsDbContext();
                    DbContext.Entry<Contract>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    DbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Update  fail");
                }
            }

            public void delete(int id)
            {
                try
                {
                    CarContractsDbContext DbContext = new CarContractsDbContext();
                    Contract? a = DbContext.Contracts.SingleOrDefault(a => a.ContractId.Equals(id));
                    DbContext.Contracts.Remove(a);
                    DbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Delete  fail");
                }
            }
            public Contract get(int id)
            {
                Contract? product = null;
                try
                {
                    CarContractsDbContext DbContext = new CarContractsDbContext();
                    product = DbContext.Contracts.SingleOrDefault(a => a.ContractId == id);
                }
                catch (Exception)
                {
                    throw new Exception("Get  fail");
                }
                return product;
            }
        }
    }

