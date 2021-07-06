using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public interface IInventoryDetailData
    {
        List<InventoryDetail> GetStoresDetail(int StoreID);
        InventoryDetail RemoveInventory(int StoreID, int itemModified, int QuantityModified);
        InventoryDetail GetSpecificInvetory(int StoreID, int itemId);
    }
}
