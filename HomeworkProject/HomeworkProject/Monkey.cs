using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Monkey : Animal, ICloneable // Наследуется от Animal и реализует ICloneable
    {
        public Monkey(string name) : base(name) // Конструктор передает имя в базовый класс
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Ooh oooh aah aaaah!");
        }

        // Реализуем метод Clone из интерфейса ICloneable
        public object Clone() 
        {
            return this.MemberwiseClone(); // Поверхностное клонирование
        }
    }
}
