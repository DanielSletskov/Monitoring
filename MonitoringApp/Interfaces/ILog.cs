namespace MonitoringApp;

public interface ILog
{
    public void LogInfo(string message);
    public void LogWarning(string message);
    public void LogError(string message, Exception ex);
}