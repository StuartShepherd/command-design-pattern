namespace CommandDesignPattern
{
    public class UndoCommand : ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Count == 0)
                return;

            _history
                .Pop()
                .Unexecute();
        }
    }
}
