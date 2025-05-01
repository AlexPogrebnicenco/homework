using HomeworkProject.Components;

namespace HomeworkProject.Decorators
{
    public class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(ITextComponent innerText) : base(innerText) { }
        public override string GetFormattedText()
        {
            return _innerText.GetFormattedText() + "[ITALIC]";
        }
    }
}
