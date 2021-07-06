using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public class AStoreData : IStoreData
    {
        GameShopContext GScontext = new GameShopContext();
        public List<Astore> GetAllStores()
        {
            return GScontext.Astores.ToList();
        }

        public Astore GetStore(int id)
        {
            return GScontext.Astores.FirstOrDefault(S => S.Id == id);
        }
    }
}
