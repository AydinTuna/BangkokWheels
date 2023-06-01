using System;
using BK.DataAccess.Data;
using BK.DataAccess.IRepository;
using BK.DataAccess.Repository.IRepository;
using BK.Models;

namespace BK.DataAccess.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        private ApplicationDbContext _db;
        public CarRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Car obj)
        {
            _db.Cars.Update(obj);
        }
    }
}

