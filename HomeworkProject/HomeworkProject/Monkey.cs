using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Monkey : Animal, ICloneable 
    {
        public Monkey(string name) : base(name) 
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Ooh oooh aah aaaah!");
        }

        public object Clone() 
        {
            return this.MemberwiseClone(); 
        }
    }
}
