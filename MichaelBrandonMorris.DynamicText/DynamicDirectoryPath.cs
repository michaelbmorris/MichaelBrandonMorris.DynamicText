using System.Windows.Input;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;
using GalaSoft.MvvmLight.Command;
using Ookii.Dialogs.Wpf;

namespace MichaelBrandonMorris.DynamicText
{
    public class DynamicDirectoryPath : DynamicText
    {
        public ICommand BrowseFolderCommand => new RelayCommand(BrowseFolder);

        private void BrowseFolder()
        {
            var folderDialog = new VistaFolderBrowserDialog();
            folderDialog.ShowDialog();

            if (!folderDialog.SelectedPath.IsNullOrWhiteSpace() &&
                !folderDialog.SelectedPath.Equals(Text))
            {
                Text = folderDialog.SelectedPath;
            }
        }
    }
}