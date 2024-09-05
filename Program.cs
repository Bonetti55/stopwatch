namespace Stopwatch
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Простой секундомер");
            var start = new Mechanism();
            start.Start();
        }
    }
}

