using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.DynamicText
{
    public sealed class DynamicTextCollection :
        ObservableCollection<DynamicText>
    {
        public DynamicTextCollection()
        {
            CollectionChanged += OnCollectionChanged;
            Add(new DynamicText());
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