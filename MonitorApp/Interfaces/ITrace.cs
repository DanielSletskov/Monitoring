namespace MonitorApp;

public interface ITrace
{
    public void TraceStart(string message);
    public void TraceStop(string message);
    public void TraceError(string message, Exception ex );
}