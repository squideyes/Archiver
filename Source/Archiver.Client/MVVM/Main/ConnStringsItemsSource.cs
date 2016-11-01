using Archiver.Client.Consts;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Archiver.Client.MVVM.Main
{
    public class ConnStringsItemsSource : IItemsSource
    {
        public ItemCollection GetValues()
        {
            var items = new ItemCollection();

            foreach (var name in WellKnown.Storages.Keys)
                items.Add(name);

            return items;
        }
    }
}
