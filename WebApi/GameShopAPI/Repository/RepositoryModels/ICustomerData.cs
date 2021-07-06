using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.RepositoryModels
{
    public interface ICustomerData
    {
        List<Acustomer> GetAllCustomers();
        Acustomer getCustomer(int ID);
        Acustomer CreateCustomer(Acustomer newCust);
        Acustomer UpdateCustomer(Acustomer updateCust);
        void DeleteCustomer(Acustomer deleteCust);
        bool isCustomer(string firstName, string lastName);
    }
}
