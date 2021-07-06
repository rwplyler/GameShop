using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.RepositoryModels
{

    public class ACustomerData :ICustomerData
    {
        GameShopContext GScontext = new GameShopContext();

        public Acustomer CreateCustomer(Acustomer newCust)
        {
            GScontext.Acustomers.Add(newCust);
            GScontext.SaveChanges();
            return newCust;
        }

        public void DeleteCustomer(Acustomer deleteCust)
        {
            throw new NotImplementedException();
        }

        public List<Acustomer> GetAllCustomers()
        {
            return GScontext.Acustomers.ToList();
        }

        public Acustomer getCustomer(int ID)
        {
            return GScontext.Acustomers.SingleOrDefault(c => c.Id == ID);
        }

        public bool isCustomer(string firstName, string lastName)
        {
            if( GScontext.Acustomers.FirstOrDefault(c => c.Fname == firstName && c.Lname == lastName) == null){
                return false;
            }
            else{
                return true;
            }
            
        }

        public Acustomer UpdateCustomer(Acustomer updateCust)
        {
            throw new NotImplementedException();
        }
    }
}
