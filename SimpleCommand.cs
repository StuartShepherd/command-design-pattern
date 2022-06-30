namespace CommandDesignPattern
{
    public class SimpleCommand : ICommand
    {
        private string _text = string.Empty;

        public SimpleCommand(string text)
        {
            _text = text;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Executing");
            Console.WriteLine($"\t Text: {_text}");
        }
    }
}
