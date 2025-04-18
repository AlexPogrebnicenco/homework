using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;

namespace HomeworkProject.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
        IList<T> FindAll();
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
