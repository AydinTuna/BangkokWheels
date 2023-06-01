using System;
using BK.Models;

namespace BK.DataAccess.IRepository
{
    public interface ICarRepository : IRepository<Car>
    {
        void Update(Car obj);
    }
}

