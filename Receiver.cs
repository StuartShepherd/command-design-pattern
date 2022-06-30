namespace CommandDesignPattern
{
    public class Receiver
    {
        public void DoAlpha(string alpha) =>
            Console.WriteLine($"\tReceiver Alpha: {alpha}");

        public void DoBeta(string beta) =>
            Console.WriteLine($"\tReceiver Beta: {beta}");
    }
}
