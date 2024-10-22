using System.Diagnostics;
namespace MonitorApp;

public class FileTrace : ITracer
{
    public static string methodName;

    public static void TraceStart(string message)
    {
        Trace.WriteLine($"Starting method: {methodName}");
    }

    public static void TraceStop(string message)
    {
        Trace.WriteLine($"Ending method: {methodName}");
    }

    public static void TraceError(string message, Exception ex)
    {
        Trace.WriteLine($"Error in method: {methodName}, Exception: {ex.Message}");
    }
}