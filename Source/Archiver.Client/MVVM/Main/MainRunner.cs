using Archiver.Client.Consts;
using System.Linq;
using System;

namespace Archiver.Client
{
    public static class MainRunner
    {
        public static void Run(Action shutdown)
        {
            var view = new MainWindow();

            var model = GetModel();

            var viewModel = new MainViewModel(model);

            view.DataContext = viewModel;

            view.Closed += (s, e) => shutdown();

            view.Show();
        }

        private static MainModel GetModel()
        {
            var model = new MainModel();

            var lastAccount = Properties.Settings.Default.LastAccount;

            if (!string.IsNullOrWhiteSpace(lastAccount))
            {
                if (WellKnown.Accounts.ContainsKey(lastAccount))
                    model.Account = lastAccount;
            }

            if (WellKnown.Accounts.Count > 0 && model.Account == null)
                model.Account = WellKnown.Accounts.First().Key;

            return model;
        }
    }
}
