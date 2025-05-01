#nullable enable

namespace HomeworkProject.Components
{
    public class PlainText : ITextComponent
    {
        private readonly string _text;
        public PlainText(string text)
        {
            _text = text;
        }
        public string GetFormattedText()
        {
             return _text;
        }
        public ITextComponent? GetInnerText()
        {
            return null;
        }
    }
}
