using Archiver.Client.Helpers;
using System.Reflection;
using System.Windows;

namespace Archiver.Client
{
    public static class Modal
    {
        private static readonly AppInfo appInfo;

        static Modal()
        {
            appInfo = new AppInfo(Assembly.GetEntryAssembly());
        }

        public static void InfoDialog(Window owner, string format,
            params object[] args)
        {
            MessageBox.Show(owner, string.Format(format, args),
                appInfo.GetTitle(),
                MessageBoxButton.OK, MessageBoxImage.Information,
                MessageBoxResult.OK, MessageBoxOptions.None);
        }

        public static void WarningDialog(Window owner, string format,
            params object[] args)
        {
            MessageBox.Show(owner, string.Format(format, args),
                appInfo.GetTitle(),
                MessageBoxButton.OK, MessageBoxImage.Warning,
                MessageBoxResult.OK, MessageBoxOptions.None);
        }

        public static void ErrorDialog(Window owner, string format,
            params object[] args)
        {
            MessageBox.Show(owner, string.Format(format, args),
                appInfo.GetTitle(),
                MessageBoxButton.OK, MessageBoxImage.Error,
                MessageBoxResult.OK, MessageBoxOptions.None);
        }

        public static void FailureDialog(string format,
            params object[] args)
        {
            MessageBox.Show(string.Format(format, args),
                appInfo.GetTitle(),
                MessageBoxButton.OK, MessageBoxImage.Exclamation,
                MessageBoxResult.OK, MessageBoxOptions.None);
        }

        public static bool YesNoDialog(Window owner, string format,
            params object[] args)
        {
            return MessageBox.Show(owner, string.Format(format, args),
                appInfo.GetTitle(),
                MessageBoxButton.YesNo, MessageBoxImage.Question,
                MessageBoxResult.Yes, MessageBoxOptions.None) ==
                MessageBoxResult.Yes;
        }
    }
}
