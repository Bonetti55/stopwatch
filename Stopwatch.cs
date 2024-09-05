namespace Stopwatch;

public class Stopwatch
{
    public void LogStopWatch(int hour, int minute, int seconds)
    {
        Console.Clear();
        Console.WriteLine($"Секундомер: {hour}:{minute}:{seconds}");
    }
}