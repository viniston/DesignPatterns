namespace DesignPatterns.Memento
{
    public class DocumentState
    {
        public DocumentState(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}
