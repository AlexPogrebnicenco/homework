using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Components;
using HomeworkProject.Decorators;
using HomeworkProject.Services;

namespace HomeworkProject.Facade
{
    public class TextFormatterFacade
    {
        private ITextComponent _component;
        private readonly TextFormatterManager _manager;

        public TextFormatterFacade(string text)
        {
            _component = new PlainText(text);
            _manager = new TextFormatterManager();
        }

        public void ApplyBold() => _component = new BoldDecorator(_component);
        public void ApplyItalic() => _component = new ItalicDecorator(_component);
        public void ApplyUnderline() => _component = new UnderlineDecorator(_component);
        public void ApplyColor(string color) => _component = new ColorDecorator(_component, color);

        public void RemoveBold() => _component = _manager.RemoveDecorator<BoldDecorator>(_component);
        public void RemoveItalic() => _component = _manager.RemoveDecorator<ItalicDecorator>(_component);
        public void RemoveUnderline() => _component = _manager.RemoveDecorator<UnderlineDecorator>(_component);
        public void RemoveColor() => _component = _manager.RemoveDecorator<ColorDecorator>(_component);

        public void Reset() => _component = _manager.RemoveAllDecorators(_component);

        public string GetFormatted() => _component.GetFormattedText();
    }
}
