namespace CommandDesignPattern
{
    public class History
    {
        private Stack<IUndoableCommand> _commands = new Stack<IUndoableCommand>();

        public int Count => _commands.Count;

        public void Push(IUndoableCommand command)
        {
            _commands
                .Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands
                .Pop();
        }
    }
}
