using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//TRACE AND LOGGING 
using System.Collections.Generic;
using OpenTelemetry;
using OpenTelemetry.Exporter.Zipkin;
using OpenTelemetry.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.Seq;

namespace WorktimeAccess;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class AccessWindow : Window
{
    public AccessWindow()
    {
        InitializeComponent();
    }

    private void Get_EMP(object sender, RoutedEventArgs e)
    {
        // Your button click logic here
        MessageBox.Show("Button was clicked!");
    }
}