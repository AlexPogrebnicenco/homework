using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Repositories
{
    public class InMemoryRepository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _storage = new List<T>();
        
        public T GetById(int id)
        {
            foreach (T item in _storage)
            {
                if (item.Id == id)
                {
                    return item; 
                }
            }

            return null;
        }

        public IList<T> FindAll()
        {
            return _storage.ToList();
        }
        public T Add(T entity)
        {
            entity.Id = _storage.Count + 1;
            _storage.Add(entity);
            return entity;
        }

        public void Delete(T entity) 
        {
            _storage.Remove(entity);
        }

        public void Update(T entity) 
        {
            int index = -1;

            for (int i = 0; i < _storage.Count; i++) 
            {
                if (_storage[i].Id == entity.Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1) 
            {
                _storage[index] = entity;
            }
        }
    } 
}
