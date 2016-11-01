using System;
using System.Windows;

namespace Archiver.Client
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs sea)
        {
            ShutdownMode = ShutdownMode.OnExplicitShutdown;

            DispatcherUnhandledException += (s, e) =>
                HandleError("Unhandled ", e.Exception);

            try
            {
                MainRunner.Run(() => Shutdown());
            }
            catch (Exception error)
            {
                HandleError("", error);
            }
        }

        private void HandleError(string prefix, Exception error)
        {
            Modal.FailureDialog($"{prefix}Error: {error.Message}");

            Shutdown();
        }
    }
}
