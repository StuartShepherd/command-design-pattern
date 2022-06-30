namespace CommandDesignPattern
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
