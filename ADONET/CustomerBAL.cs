using ADONET.DAL;
using ADONET.Model;
using System.Collections.Generic;

namespace ADONET.BAL
{
    public class CustomerBAL
    {
        CustomerDAL dal = new CustomerDAL();
        public List<CustomerBEL> ReadCustomerList() => dal.ReadCustomerList();
    }
}