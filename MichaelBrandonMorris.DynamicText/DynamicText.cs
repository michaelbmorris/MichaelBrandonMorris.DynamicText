using System.ComponentModel;
using System.Runtime.CompilerServices;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.DynamicText
{
    /// <summary>
    ///     Class DynamicText.
    /// </summary>
    /// <seealso cref="INotifyPropertyChanged" />
    /// TODO Edit XML Comment Template for DynamicText
    public class DynamicText : INotifyPropertyChanged
    {
        /// <summary>
        ///     The add button is visible
        /// </summary>
        /// TODO Edit XML Comment Template for _addButtonIsVisible
        private bool _addButtonIsVisible;

        /// <summary>
        ///     The text
        /// </summary>
        /// TODO Edit XML Comment Template for _text
        private string _text;

        /// <summary>
        ///     Gets or sets a value indicating whether [add button is
        ///     visible].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [add button is visible]; otherwise,
        ///     <c>false</c>.
        /// </value>
        /// TODO Edit XML Comment Template for AddButtonIsVisible
        public bool AddButtonIsVisible
        {
            get => _addButtonIsVisible;
            set
            {
                if (_addButtonIsVisible == value)
                {
                    return;
                }

                _addButtonIsVisible = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        /// TODO Edit XML Comment Template for Text
        public string Text
        {
            get => _text;
            set
            {
                if (_text != null
                    && value != null
                    && _text.Equals(value))
                {
                    return;
                }

                _text = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     Occurs when a property value changes.
        /// </summary>
        /// TODO Edit XML Comment Template for PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Determines whether [is null or empty].
        /// </summary>
        /// <returns>
        ///     <c>true</c> if [is null or empty]; otherwise,
        ///     <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNullOrEmpty
        public bool IsNullOrEmpty()
        {
            return Text.IsNullOrEmpty();
        }

        /// <summary>
        ///     Determines whether [is null or white space].
        /// </summary>
        /// <returns>
        ///     <c>true</c> if [is null or white space];
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNullOrWhiteSpace
        public bool IsNullOrWhiteSpace()
        {
            return Text.IsNullOrWhiteSpace();
        }

        /// <summary>
        ///     Notifies the property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// TODO Edit XML Comment Template for NotifyPropertyChanged
        private void NotifyPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}