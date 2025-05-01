#nullable enable
namespace HomeworkProject.Components
{
    public interface ITextComponent
    {
        string GetFormattedText();
        ITextComponent? GetInnerText();
    }
}
