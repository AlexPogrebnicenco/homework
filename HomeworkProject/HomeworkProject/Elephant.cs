using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name) // Конструктор передает имя в базовый класс
        { 
        }

        // Переопределяем метод Speak для слона
        public override void Speak()
        {
            Console.WriteLine("Trumpet!");
        }
    }
}
