using Archiver.Client.Consts;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Archiver.Client.MVVM.Main
{
    public class AccountItemsSource : IItemsSource
    {
        public ItemCollection GetValues()
        {
            var items = new ItemCollection();

            foreach (var name in WellKnown.Accounts.Keys)
                items.Add(name);

            return items;
        }
    }
}
