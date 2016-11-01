using Archiver.Client.Consts;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Archiver.Client
{
    public class MainViewModel : NotifyBase<MainViewModel>
    {
        private string storage;

        private TaskFactory uiFactory = new TaskFactory(
            TaskScheduler.FromCurrentSynchronizationContext());

        public MainViewModel(MainModel model)
        {
            Model = model;

            Storages = WellKnown.Storages.Select(cs => cs.Key).ToList();
        }

        public MainModel Model { get; }

        public List<string> Storages { get; }
    }
}
