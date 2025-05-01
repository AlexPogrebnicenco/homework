using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Components;

namespace HomeworkProject.Decorators
{
    public class BoldDecorator : TextDecorator
    {
        public BoldDecorator(ITextComponent innerText) : base(innerText) { }
        public override string GetFormattedText()
        {
            return _innerText.GetFormattedText() + "[BOLD]"; 
        }
    }
}
