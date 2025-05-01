using HomeworkProject.Components;

namespace HomeworkProject.Decorators
{
    public class UnderlineDecorator : TextDecorator
    {
        public UnderlineDecorator(ITextComponent innerText) : base(innerText) { }
        public override string GetFormattedText()
        {
            return _innerText.GetFormattedText() + "[UNDERLINE]";
        }
    }
}
