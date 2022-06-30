namespace CommandDesignPattern
{
    public class BoldCommand : IUndoableCommand
    {
        private History _history;
        private HTMLDocument _htmlDocument;
        private string _previousContent = string.Empty;

        public BoldCommand(HTMLDocument htmlDocument, History history)
        {
            _htmlDocument = htmlDocument;
            _history = history;
        }

        public void Execute()
        {
            _previousContent = _htmlDocument.GetContent();
            _htmlDocument.MakeBold();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _htmlDocument.SetContent(_previousContent);
        }
    }
}
