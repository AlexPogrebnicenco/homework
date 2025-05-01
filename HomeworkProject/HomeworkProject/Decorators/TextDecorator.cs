#nullable enable
using HomeworkProject.Components;

namespace HomeworkProject.Decorators
{
    public abstract class TextDecorator : ITextComponent
    {
        protected readonly ITextComponent _innerText;
        protected TextDecorator(ITextComponent innerText)
        {
            _innerText = innerText;
        }
        public abstract string GetFormattedText();
        public ITextComponent? GetInnerText()
        {
            return _innerText;
        }
    }
}
