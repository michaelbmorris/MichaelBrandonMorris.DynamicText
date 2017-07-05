using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.DynamicText
{
    /// <summary>
    ///     Class DynamicDirectoryPathCollection.
    /// </summary>
    /// <seealso cref="DynamicDirectoryPath" />
    /// <seealso cref="ObservableCollection{T}" />
    public sealed class DynamicDirectoryPathCollection
        : ObservableCollection<DynamicDirectoryPath>
    {
        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="DynamicDirectoryPathCollection" /> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public DynamicDirectoryPathCollection()
        {
            CollectionChanged += OnCollectionChanged;
            Add(new DynamicDirectoryPath());
        }

        /// <summary>
        ///     Occurs when an item is added, removed, changed, moved,
        ///     or the entire list is refreshed.
        /// </summary>
        public override event NotifyCollectionChangedEventHandler
            CollectionChanged
            {
                add => base.CollectionChanged += value;
                remove => base.CollectionChanged -= value;
            }

        /// <summary>
        ///     Determines whether this instance contains text.
        /// </summary>
        /// <returns>System.Boolean.</returns>
        public bool ContainsText()
        {
            return this.Any(x => !x.Text.IsNullOrWhiteSpace());
        }

        /// <summary>
        ///     Handles the <see cref="E:CollectionChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        ///     The <see cref="NotifyCollectionChangedEventArgs" />
        ///     instance containing the event data.
        /// </param>
        private void OnCollectionChanged(
            object sender,
            NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in this)
            {
                item.AddButtonIsVisible = item == this.Last();
            }
        }
    }
}