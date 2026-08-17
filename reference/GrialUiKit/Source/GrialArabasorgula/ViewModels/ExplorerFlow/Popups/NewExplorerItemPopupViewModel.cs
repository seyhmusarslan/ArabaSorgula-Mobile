/* [grial-metadata] id: Grial#NewExplorerItemPopupViewModel.cs version: 1.1.6 */

using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NewExplorerItemPopupViewModel : ObservableObject
    {
        private string _itemName;
        private FileType? _fileType;
        private Color _selectedColor;
        private IExplorerItem _modifyItem;

        /// <summary>
        /// If folder is null, opens a popup to create a new folder else opens a popup to modify the folder color.
        /// </summary>
        public NewExplorerItemPopupViewModel(List<string> folderColors, Folder folder = null)
        {
            FolderColors = folderColors.Select((stringColor) => Color.FromArgb(stringColor)).ToList();
            _fileType = null;

            if (folder == null)
            {
                Title = "New Folder";
                ShowColors = true;
                ShowNameField = true;
            }
            else
            {
                Title = "Pick a new color";
                ShowColors = true;
                _modifyItem = folder;
                SelectedColor = FolderColors.FirstOrDefault((color) => Color.FromArgb(folder.BackgroundColor).Equals(color) == true, FolderColors[0]);
            }
        }

        /// <summary>
        /// Opens a popup to create a new file.
        /// </summary>
        public NewExplorerItemPopupViewModel(FileType fileType)
        {
            FolderColors = null;
            _fileType = fileType;
            Title = "New File";
            ShowNameField = true;
        }

        /// <summary>
        /// Opens a popup to rename the explorerItem.
        /// </summary>
        public NewExplorerItemPopupViewModel(IExplorerItem explorerItem)
        {
            FolderColors = null;
            _fileType = null;
            _modifyItem = explorerItem;
            ShowNameField = true;
            Title = "Rename";
            ItemName = explorerItem.Name;
        }

        public TaskCompletionSource<IExplorerItem> Result { get; } = new TaskCompletionSource<IExplorerItem>();
        public ICommand SaveCommand => new Command(async () => await OnSaveCommand());
        public ICommand CancelCommand => new Command(async () => await OnCancelCommand());

        public List<Color> FolderColors { get; set; }

        public string Title { get; set; }
        public bool ShowColors { get; set; }
        public bool ShowNameField { get; set; }

        public Color SelectedColor
        {
            get => _selectedColor;
            set => SetProperty(ref _selectedColor, value);
        }

        public string ItemName
        {
            get => _itemName;
            set => SetProperty(ref _itemName, value);
        }

        private Task OnSaveCommand()
        {
            if (_modifyItem != null)
            {
                if (FolderColors != null)
                {
                    (_modifyItem as Folder).BackgroundColor = SelectedColor.ToArgbHex(false);
                }
                else
                {
                    _modifyItem.Name = ItemName;
                }

                Result.TrySetResult(_modifyItem);
            }
            else
            {
                IExplorerItem item;
                if (FolderColors != null)
                {
                    item = new Folder
                    {
                        Name = ItemName,
                        BackgroundColor = SelectedColor.ToArgbHex(false),
                        CreationDate = DateTime.Now.ToString("ddd dd, yyyy")
                    };
                }
                else
                {
                    item = new File
                    {
                        Name = ItemName,
                        Type = _fileType.Value,
                        CreationDate = DateTime.Now.ToString("ddd dd, yyyy")
                    };
                }

                Result.TrySetResult(item);
            }

            return IPopupService.Current.PopAsync();
        }

        private Task OnCancelCommand()
        {
            Result.TrySetResult(null);
            return IPopupService.Current.PopAsync();
        }
    }
}
