using System;
using BK.DataAccess.Data;
using BK.DataAccess.IRepository;
using BK.DataAccess.Repository.IRepository;

namespace BK.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _db;
        public ICarRepository Car { get; private set; }
        public IAdRepository Ad { get; private set; }
        public ICarSpecificationRepository CarSpecification { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Car = new CarRepository(_db);
            Ad = new AdRepository(_db);
            CarSpecification = new CarSpecificationRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

