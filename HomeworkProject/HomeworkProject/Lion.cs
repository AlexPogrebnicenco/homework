using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Lion : Animal // Наследуем от класса Animal
    {
        public Lion(string name) : base(name)  // Конструктор, передающий имя в базовый класс
        {

        }

        // Переопределяем метод Speack 
        public override void Speak()
        {
            Console.WriteLine("Roar!"); // Уникальый звук 
        }
    }
}
