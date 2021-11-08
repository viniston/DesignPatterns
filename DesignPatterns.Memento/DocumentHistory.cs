using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Memento
{
    public class DocumentHistory
    {
        private readonly Stack<DocumentState> _states;

        public DocumentHistory()
        {
            _states = new Stack<DocumentState>();
        }

        public void Push(DocumentState state)
        {
            _states.Push(state);
        }

        public DocumentState Pop()
        {
           return _states.Pop();
        }
    }
}
