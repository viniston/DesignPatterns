namespace DesignPatterns.Memento
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public void SetFontName(string value)
        {
            _fontName = value;
        }

        public string GetFontName()
        {
            return _fontName;
        }

        public void SetFontSize(int value)
        {
            _fontSize = value;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public DocumentState CreateState()
        {
            return new(_content, _fontName, _fontSize);
        }

        public void RestoreState(DocumentState state)
        {
            _content = state.GetContent();
            _fontName = state.GetFontName();
            _fontSize = state.GetFontSize();
        }

        public override string ToString()
        {
            return $"Document: Content = {_content}, FontName = {_fontName}, FontSize= {_fontSize}";
        }
    }
}