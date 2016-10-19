using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.DynamicText
{
    public sealed class DynamicDirectoryPathCollection :
        ObservableCollection<DynamicDirectoryPath>
    {
        public DynamicDirectoryPathCollection()
        {
            CollectionChanged += OnCollectionChanged;
            Add(new DynamicDirectoryPath());
        }

        public override event NotifyCollectionChangedEventHandler
            CollectionChanged
            {
                add
                {
                    base.CollectionChanged += value;
                }
                remove
                {
                    base.CollectionChanged -= value;
                }
            }

        public bool ContainsText()
        {
            return this.Any(x => !x.Text.IsNullOrWhiteSpace());
        }

        private void OnCollectionChanged(
            object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in this)
            {
                item.AddButtonIsVisible = item == this.Last();
            }
        }
    }
}