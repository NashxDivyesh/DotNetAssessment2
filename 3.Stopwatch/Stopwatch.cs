public class Stopwatch
{
    public DateTime StartedAt { get; private set; } = DateTime.MinValue;
    public DateTime StoppedAt { get; private set; }
    public TimeSpan Duration { get; private set; }
    private bool _isStarted;
    public void Start()
    {
        if (_isStarted)
            throw new InvalidOperationException("Stopwatch is already started!");

        //To handle start -> stop, start -> stop
        if (StartedAt == DateTime.MinValue)
            StartedAt = DateTime.Now;

        _isStarted = true;
    }

    public void Stop()
    {
        _isStarted = false;
        StoppedAt = DateTime.Now;
        Duration = StoppedAt - StartedAt;
    }

}