namespace CommandDesignPattern
{
    public class HTMLDocument
    {
        private string _content = string.Empty;

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public void MakeBold()
        {
            _content = $"<b>{_content}</b>";
        }

        public void MakeItalic()
        {
            _content = $"<l>{_content}</l>";
        }
    }
}
