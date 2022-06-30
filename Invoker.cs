namespace CommandDesignPattern
{
    public class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomething()
        {
            if (_onStart is ICommand)
                _onStart.Execute();

            Console.WriteLine($"Invoker: DoSomething");

            if (_onFinish is ICommand)
                _onFinish.Execute();
        }
    }
}
