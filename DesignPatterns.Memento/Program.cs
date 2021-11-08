using System;

namespace DesignPatterns.Memento
{
    class Program
    {
        static void Main()
        {
            var document = new Document();
            var history = new DocumentHistory();

            document.SetContent("Hello");
            history.Push(document.CreateState());

            document.SetFontName("Font 1");
            history.Push(document.CreateState());

            document.SetFontSize(10);

            Console.WriteLine(document);

            document.RestoreState(history.Pop());
            Console.WriteLine(document);

            document.RestoreState(history.Pop());
            Console.WriteLine(document);

            Console.ReadLine();

        }
    }
}
