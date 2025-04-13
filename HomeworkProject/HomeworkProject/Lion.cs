using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Lion : Animal 
    {
        public Lion(string name) : base(name)  
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Roar!");
        }
    }
}
