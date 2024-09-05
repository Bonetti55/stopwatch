namespace Stopwatch
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Это простой секундомер");
            var start = new Mechanism();
            start.Start();
        }
    }
}

