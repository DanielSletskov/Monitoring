using System.Diagnostics;
namespace MonitoringApp;

public class FileTrace : ITrace
{
    public static string methodName;

    public void TraceStart(string message)
    {
        Trace.WriteLine($"Starting method: {methodName}");
    }

    public void TraceStop(string message)
    {
        Trace.WriteLine($"Ending method: {methodName}");
    }

    public void TraceError(string message, Exception ex)
    {
        Trace.WriteLine($"Error in method: {methodName}, Exception: {ex.Message}");
    }
}