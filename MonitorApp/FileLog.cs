using System.IO.Enumeration;

namespace MonitorApp;
using System;
using System.IO;

public class FileLog : ILogger
{
    private static readonly string _logFilePath = @"C:\Users\Danie\Monitoring\MonitorApp\Logging\";

    public FileLog()
    {
    }
    
    //Log usage information 
    public static void LogInfo(string message)
    {
        Log("INFO", message, _logFilePath);
    }

    //Log warning 
    public static void LogWarning(string message)
    {
        Log("WARNING", message, _logFilePath);
    }

    //Logging Errors
    public static void LogError(string message, Exception ex)
    {
        Log("ERROR", message + (ex != null ? $" Exception: {ex.Message}" : ""), null);
    }
    
    // Private method to handle actual logging
    private static void Log(string logLevel, string message, string _logFilePath)
    {
        DateTime now = DateTime.Now;
        string fileName = now.ToString("yyyy-MM-dd") +".txt"; 
        //Ensure File exist
        if(File.Exists(_logFilePath+fileName))
        {
            File.WriteAllText(_logFilePath+fileName,"This log file was created "+ now.ToString("yyyy-MM-dd \n"));
            var logMessage = $"{DateTime.Now} [{logLevel}] {message}";
            File.WriteAllText(_logFilePath, logMessage + Environment.NewLine);
            Console.WriteLine("Log file path: " + _logFilePath);  
        } else
        { // IF file doesnt exist create new file with name being the date it was created. 
            string NewFileMessage = "This Log file was created " + now.ToString("yyyy-MM-dd \n ");
            File.WriteAllText(_logFilePath + fileName, NewFileMessage);
            Console.WriteLine("File created successfully.");  
        }

    }
}