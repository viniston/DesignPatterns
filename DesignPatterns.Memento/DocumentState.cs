namespace DesignPatterns.Memento
{
    public class DocumentState
    {
        private string Content { get; }
        private string FontName { get; }
        private int FontSize { get; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string GetContent()
        {
            return Content;
        }

        public string GetFontName()
        {
            return FontName;
        }

        public int GetFontSize()
        {
            return FontSize;
        }
    }
}
