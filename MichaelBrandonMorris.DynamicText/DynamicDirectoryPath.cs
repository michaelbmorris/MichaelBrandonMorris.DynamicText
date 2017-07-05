using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;
using Ookii.Dialogs.Wpf;

namespace MichaelBrandonMorris.DynamicText
{
    /// <summary>
    ///     Class DynamicDirectoryPath.
    /// </summary>
    /// <seealso cref="DynamicText" />
    /// TODO Edit XML Comment Template for DynamicDirectoryPath
    public class DynamicDirectoryPath : DynamicText
    {
        /// <summary>
        ///     Gets the browse folder command.
        /// </summary>
        /// <value>The browse folder command.</value>
        /// TODO Edit XML Comment Template for BrowseFolderCommand
        public ICommand BrowseFolderCommand => new RelayCommand(BrowseFolder);

        /// <summary>
        ///     Browses the folder.
        /// </summary>
        /// TODO Edit XML Comment Template for BrowseFolder
        private void BrowseFolder()
        {
            var folderDialog = new VistaFolderBrowserDialog();
            folderDialog.ShowDialog();

            if (!folderDialog.SelectedPath.IsNullOrWhiteSpace()
                && !folderDialog.SelectedPath.Equals(Text))
            {
                Text = folderDialog.SelectedPath;
            }
        }
    }
}