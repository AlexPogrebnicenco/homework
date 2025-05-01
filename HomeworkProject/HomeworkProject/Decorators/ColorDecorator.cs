using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Components;

namespace HomeworkProject.Decorators
{
    public class ColorDecorator : TextDecorator
    {
        private readonly string _color;
        public ColorDecorator(ITextComponent innerText, string color) : base(innerText) 
        {
            _color = color;
        }
        public override string GetFormattedText()
        {
            return _innerText.GetFormattedText() + $"[COLOR: {_color}]";
        }
        public string GetColor() => _color;
    }
}
