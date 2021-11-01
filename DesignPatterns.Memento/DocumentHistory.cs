using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Memento
{
    public class DocumentHistory
    {
        private readonly List<DocumentState> _states;

        public DocumentHistory()
        {
            _states = new List<DocumentState>();
        }

        public void Push(DocumentState state)
        {
            _states.Add(state);
        }

        public DocumentState Pop()
        {
            if (!_states.Any())
            {
                return null;
            }
            var lastIndex = _states.Count - 1;
            var lastState = _states.ElementAt(lastIndex);
            _states.RemoveAt(lastIndex);
            return lastState;
        }
    }
}
