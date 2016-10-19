using System.ComponentModel;
using System.Runtime.CompilerServices;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.DynamicText
{
    public class DynamicText : INotifyPropertyChanged
    {
        private bool _addButtonIsVisible;
        private string _text;

        public bool AddButtonIsVisible
        {
            get
            {
                return _addButtonIsVisible;
            }
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

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != null && value != null && _text.Equals(value))
                {
                    return;
                }

                _text = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsNullOrEmpty()
        {
            return Text.IsNullOrEmpty();
        }

        public bool IsNullOrWhiteSpace()
        {
            return Text.IsNullOrWhiteSpace();
        }

        private void NotifyPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}