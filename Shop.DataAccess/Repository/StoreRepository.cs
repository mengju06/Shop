using Shop.DataAccess.Data;
using Shop.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.DataAccess.Repository
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        private ApplicationDbContext _db;
        public StoreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}

        public void Update(Store obj)
        {
            _db.Stores.Update(obj);
        }
    }
}
