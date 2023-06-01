using System;
using BK.DataAccess.IRepository;

namespace BK.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public ICarSpecificationRepository CarSpecification { get; }
        public ICarRepository Car { get; }
        public IAdRepository Ad { get; }

        void Save();
    }
}

