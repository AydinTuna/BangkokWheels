using System;
using BK.Models;

namespace BK.DataAccess.IRepository
{
    public interface IBrandRepository : IRepository<Brand>
    {
        void Update(Brand obj);
    }
}

