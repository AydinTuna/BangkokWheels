using System;
using BK.Models;

namespace BK.DataAccess.IRepository
{
    public interface IAdRepository : IRepository<Ad>
    {
        void Update(Ad obj);
    }
}

