using System;
using BK.Models;

namespace BK.DataAccess.IRepository
{
    public interface ICarSpecificationRepository : IRepository<CarSpecification>
    {
        void Update(CarSpecification obj);
    }
}

