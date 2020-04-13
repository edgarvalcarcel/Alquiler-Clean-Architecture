using Alquiler.Application.Interfaces.Persistence;

namespace Alquiler.Persistence.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _database;

        public UnitOfWork(IDatabaseContext database)
        {
            _database = database;
        }

        public void Save()
        {
            _database.Save();
        }
    }
}