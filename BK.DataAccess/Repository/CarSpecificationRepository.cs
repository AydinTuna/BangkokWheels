using System;
using System.Linq.Expressions;
using BK.DataAccess.Data;
using BK.DataAccess.IRepository;
using BK.DataAccess.Repository.IRepository;
using BK.Models;

namespace BK.DataAccess.Repository
{
    public class CarSpecificationRepository : Repository<CarSpecification>, ICarSpecificationRepository
    {
        private ApplicationDbContext _db;
        public CarSpecificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CarSpecification obj)
        {
            _db.CarSpecifications.Update(obj);
        }

    }
}

