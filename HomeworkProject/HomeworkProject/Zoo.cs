using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Zoo : IEnumerable<Animal> // Класс Zoo реализует интерфейс IEnumerable<Animal>
    {
        private List<Animal> _animals = new List<Animal>(); // Список животных

        // Метод для добавления животных в зоопарк
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        // Реализация интерфейса IEnumerable 
        public IEnumerator<Animal> GetEnumerator()
        {
            return _animals.GetEnumerator(); // Возвращаем перечислитель для List<Animal>
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Переопредляем для работы с нестандартными коллекциями
        }
    }
}
