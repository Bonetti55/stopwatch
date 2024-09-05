namespace Stopwatch;

public class Mechanism
{
    private int _hour;
    private int _minute;
    private int _seconds;

    private readonly Stopwatch _stopwatch = new Stopwatch();

    public void Start()
    {
        _seconds += 1;
        SecondTimer();
    }

    private void Timer()
    {
        if (_seconds != 60) return;
        _minute += 1;
        _seconds -= 60;
        if (_minute == 60)
        {
            _hour += 1;
        }
    }

    private void SecondTimer()
    {
        while (_seconds < 60)
        {
            _seconds += 1;
            Timer();
            _stopwatch.LogStopWatch(_hour, _minute, _seconds);
            Thread.Sleep(1000);
        }
    }
}