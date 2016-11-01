using System.Threading;
using System.Threading.Tasks;

namespace Archiver.Client
{
    public class MainViewModel : NotifyBase<MainViewModel>
    {
        private CancellationTokenSource cts;

        private TaskFactory uiFactory = new TaskFactory(
            TaskScheduler.FromCurrentSynchronizationContext());

        public MainViewModel(MainModel model)
        {
            Model = model;
        }

        public MainModel Model { get; }
    }
}
