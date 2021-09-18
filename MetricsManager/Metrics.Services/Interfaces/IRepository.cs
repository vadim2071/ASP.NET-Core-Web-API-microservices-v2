using Metrics.Services.Model;
using System.Collections.Generic;

namespace Metrics.Services.Interfaces
{
    public interface IRepository<T> where T : baseMetric
    {
        IList<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
