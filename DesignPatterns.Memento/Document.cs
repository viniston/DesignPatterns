namespace DesignPatterns.Memento
{
    public class Document
    {
        private string _content;

        public void SetContent(string value)
        {
            _content = value;
        }

        public string GetContent()
        {
            return _content;
        }

        public DocumentState CreateState()
        {
            return new(_content);
        }

        public void RestoreState(DocumentState state)
        {
            SetContent(state?.Content);
        }
    }
}
