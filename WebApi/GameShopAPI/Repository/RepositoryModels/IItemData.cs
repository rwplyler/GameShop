using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public interface IItemData
    {
        List<AnItem> GetAllItems();
        AnItem GetItem(int Id);
    }
}
