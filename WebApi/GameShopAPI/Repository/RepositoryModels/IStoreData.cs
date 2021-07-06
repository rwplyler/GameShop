using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public interface IStoreData
    {
        Astore GetStore(int id);
        List<Astore> GetAllStores();
    }
}
