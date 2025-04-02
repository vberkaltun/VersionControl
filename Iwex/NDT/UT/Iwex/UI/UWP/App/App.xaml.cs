using System.Diagnostics.CodeAnalysis;
using Microsoft.UI.Xaml;

namespace Applus.NDT.UT.Iwex.UI.UWP.App;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
[SuppressMessage("Naming", "CA1724: Type names should not match namespaces", Justification = "TBD")]
public partial class App : Application
{
    private Window _window;

    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Activate();
    }
}
