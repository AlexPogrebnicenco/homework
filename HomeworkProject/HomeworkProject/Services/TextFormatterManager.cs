using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Components;
using HomeworkProject.Decorators;

namespace HomeworkProject.Services
{
    public class TextFormatterManager : ITextFormatterManager
    {
        public ITextComponent RemoveDecorator<T>(ITextComponent component) where T : ITextComponent
        {
            if (component is PlainText)
            {
                return component;
            }
            if (component is T)
            {
                return component.GetInnerText() ?? component;
            }

            var inner = component.GetInnerText();
            if (inner == null)
            {
                return component;
            }

            var updatedInner = RemoveDecorator<T>(inner);

            if (component is BoldDecorator)
                return new BoldDecorator(updatedInner);
            if (component is ItalicDecorator)
                return new ItalicDecorator(updatedInner);
            if (component is UnderlineDecorator)
                return new UnderlineDecorator(updatedInner);
            if (component is ColorDecorator color)
                return new ColorDecorator(updatedInner, color.GetColor());

            return component;
        }

        public ITextComponent RemoveAllDecorators(ITextComponent component) 
        {
            while (component is TextDecorator)
            {
                component = component.GetInnerText()!;
            }
            return component;
        }
    }
}
