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
            var objFromDb = _db.Cars.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Brand = obj.Brand;
                objFromDb.Model = obj.Model;
                objFromDb.ProductionYear = obj.ProductionYear;
                objFromDb.Type = obj.Type;
                objFromDb.FuelType = obj.FuelType;
                objFromDb.Engine = obj.Engine;
                objFromDb.Transmission = obj.Transmission;
                objFromDb.Mileage = obj.Mileage;
                objFromDb.SalePrice = obj.SalePrice;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
                objFromDb.CarSpecificationId = obj.CarSpecificationId;
                objFromDb.Status = obj.Status;
                objFromDb.CreatedAt = DateTime.Now;
                objFromDb.AdTitle = obj.AdTitle;
                objFromDb.AdDescription = obj.AdDescription;
            }
        }
    }
}

