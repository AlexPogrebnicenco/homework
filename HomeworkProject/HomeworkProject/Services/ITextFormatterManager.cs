using HomeworkProject.Components;

namespace HomeworkProject.Services
{
    public interface ITextFormatterManager
    {
        ITextComponent RemoveDecorator<T>(ITextComponent component) where T : ITextComponent;
        ITextComponent RemoveAllDecorators(ITextComponent component);
    }
}
