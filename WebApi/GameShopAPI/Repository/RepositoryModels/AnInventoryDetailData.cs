using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    class AnInventoryDetailData : IInventoryDetailData
    {
        GameShopContext GScontext = new GameShopContext();
        public InventoryDetail GetSpecificInvetory(int StoreID, int itemId)
        {
            return GScontext.InventoryDetails.FirstOrDefault(s => s.StoreId == StoreID && s.ItemId == itemId);
        }

        public List<InventoryDetail> GetStoresDetail(int StoreID)
        {
            throw new NotImplementedException();
        }

        public InventoryDetail RemoveInventory(int StoreID, int itemModified, int QuantityModified)
        {
            throw new NotImplementedException();
        }
    }
}
