using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public interface IOrderData
    {
        List<Aorder> GetAllOrders();
        Aorder GetAnOrder(int id);
        Aorder SetAnOrder(Aorder newOrder);
    }
}
