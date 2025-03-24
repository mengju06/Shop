using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.DataAccess.Repository.IRepository
{
    public interface IStoreRepository : IRepository<Store>
    {
        void Update(Store obj);
        //void Save();
    }
}
