using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPlaner.Models;
using MonitorApp;
    


namespace WebPlaner.Controllers;

public class HomeController : Controller
{
    private FileLog _fileLog;
    private FileTrace _fileTrace;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, FileLog fileLog, FileTrace fileTrace)
    {

        _logger = logger;
    }

    public IActionResult Index()
    {
        _fileLog = new FileLog();
        _fileTrace = new FileTrace();    
        _fileLog.LogInfo("Starting web planer");
        _fileTrace.TraceStart(nameof(Index));
        try
        {
            _fileLog.LogInfo("Handling request for Home/Index");
            return View();
        }
        catch (Exception ex)
        {
            _fileLog.LogError("An error occurred while processing the request.", ex);
            _fileTrace.TraceError(nameof(Index), ex);
            return StatusCode(500, "Internal server error");
        }
        finally
        {
            _fileTrace.TraceStop(nameof(Index));
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}