using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public class MockCustomerData : ICustomerData
    {
        
        public Acustomer CreateCustomer(Acustomer newCust)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Acustomer deleteCust)
        {
            throw new NotImplementedException();
        }

        public List<Acustomer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Acustomer getCustomer(int ID)
        {
            throw new NotImplementedException();
        }

        public bool isCustomer(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Acustomer UpdateCustomer(Acustomer updateCust)
        {
            throw new NotImplementedException();
        }
    }
}
