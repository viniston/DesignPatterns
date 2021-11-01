using System;

namespace DesignPatterns.Memento
{
    class Program
    {
        static void Main()
        {
            var document = new Document();
            var history = new DocumentHistory();

            document.SetContent("a");
            history.Push(document.CreateState());
            Console.WriteLine($"Created state for {document.GetContent()}");

            document.SetContent("b");
            history.Push(document.CreateState());
            Console.WriteLine($"Created state for {document.GetContent()}");

            document.SetContent("c");
            Console.WriteLine($"Set document content as {document.GetContent()} but do not create any state");

            document.RestoreState(history.Pop());
            Console.WriteLine($"Restored state to {document.GetContent()}");

            document.RestoreState(history.Pop());
            Console.WriteLine($"Restored state to {document.GetContent()}");

            Console.ReadLine();

        }
    }
}
