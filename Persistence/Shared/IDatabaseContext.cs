using System.Data.Entity;
using Alquiler.Domain.Common;
namespace Alquiler.Persistence.Shared
{
    public interface IDatabaseContext
    { 
        IDbSet<T> Set<T>() where T : class, IEntity;
        void Save();
    }
}