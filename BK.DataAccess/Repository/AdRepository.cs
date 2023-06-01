using System;
using BK.DataAccess.Data;
using BK.DataAccess.IRepository;
using BK.DataAccess.Repository.IRepository;
using BK.Models;

namespace BK.DataAccess.Repository
{
    public class AdRepository : Repository<Ad>, IAdRepository
    {
        private ApplicationDbContext _db;
        public AdRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Ad obj)
        {
            _db.Ads.Update(obj);
        }
    }
}

