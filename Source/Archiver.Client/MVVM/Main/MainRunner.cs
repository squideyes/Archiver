﻿using Archiver.Client.Consts;
using System.Linq;
using System;

namespace Archiver.Client
{
    public static class MainRunner
    {
        public static void Run(Action shutdown)
        {
            var view = new MainWindow();

            var model = new MainModel();

            model.Storage = WellKnown.Storages.FirstOrDefault().Key;

            var vm = new MainViewModel(model);

            view.DataContext = vm;

            view.Closed += (s, e) => shutdown();

            view.Show();
        }
    }
}
