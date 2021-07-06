using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public interface IOrderDetailData
    {
        List<AorderDetail> GetAllOrderDetails(int orderNumber);
        AorderDetail AddOrderDetail(AorderDetail aorderDetail);

    }
}
