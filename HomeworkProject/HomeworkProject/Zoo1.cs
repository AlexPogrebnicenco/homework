using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Zoo1 : IEnumerable<Animal>
    {
       private readonly List<Animal> _animalos = new List<Animal>();

       public void AddAnimal(Animal animal)
        {
            _animalos.Add(animal);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return _animalos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
            
     }
}
