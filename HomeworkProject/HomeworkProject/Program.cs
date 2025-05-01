using System;
using HomeworkProject.Components;
using HomeworkProject.Decorators;
using HomeworkProject.Facade;
using HomeworkProject.Services;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunWithoutFacade();
            RunWithFacade();
        }

        static void RunWithoutFacade()
        {
            Console.WriteLine("\t>>> This example doesn't use Facade <<<");
            ITextComponent text = new PlainText("This is text example");
            text = new ItalicDecorator(text);
            text = new BoldDecorator(text);
            text = new UnderlineDecorator(text);
            text = new ColorDecorator(text, "white");

            Console.WriteLine("Formatted:");
            Console.WriteLine(text.GetFormattedText());

            var manager = new TextFormatterManager();
            var noBold = manager.RemoveDecorator<BoldDecorator>(text);
            Console.WriteLine("Without BOLD:");
            Console.WriteLine(noBold.GetFormattedText());

            var plain = manager.RemoveAllDecorators(text);
            Console.WriteLine("Plain text only:");
            Console.WriteLine(plain.GetFormattedText());
            Console.WriteLine("\n---------------------------------------------------------\n");
        }

        static void RunWithFacade()
        {
            Console.WriteLine("\t>>> This example uses FACADE <<<");
            var formatter = new TextFormatterFacade("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            formatter.ApplyItalic();
            formatter.ApplyBold();
            formatter.ApplyColor("white");
            Console.WriteLine("Formated:");
            Console.WriteLine(formatter.GetFormatted());

            formatter.RemoveBold();
            Console.WriteLine("Without Bold:");
            Console.WriteLine(formatter.GetFormatted());

            formatter.Reset();
            Console.WriteLine("Reset:");
            Console.WriteLine(formatter.GetFormatted());
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}
