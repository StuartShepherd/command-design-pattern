namespace CommandDesignPattern
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _alpha;
        private readonly string _beta;

        public ComplexCommand(
            Receiver receiver,
            string alpha,
            string beta)
        {
            _receiver = receiver;
            _alpha = alpha;
            _beta = beta;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Executing:");

            _receiver.DoAlpha(_alpha);
            _receiver.DoBeta(_beta);
        }
    }
}
