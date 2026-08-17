/* [grial-metadata] id: Grial#ExplorerFlowViewModel.cs version: 2.0.6 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ExplorerFlowViewModel : ObservableObject
    {
        private Folder _parentFolder = null;

        public ExplorerFlowViewModel()
        {
            RootDirectory = null;
            LoadData();
        }

        public ExplorerFlowViewModel(Folder parent)
        {
            LoadData();

            Items.Clear();
            Files.Clear();
            Folders.Clear();

            _parentFolder = parent;

            if (_parentFolder.Content != null)
            {
                foreach (var item in _parentFolder.Content)
                {
                    Items.Add(item);
                }
            }
        }

        public static ObservableCollection<IExplorerItem> RootDirectory { get; private set; }

        public List<File> Files { get; } = new List<File>();
        public List<Folder> Folders { get; } = new List<Folder>();
        public List<string> FolderColors { get; } = new List<string>();
        public ObservableCollection<IExplorerItem> Items { get; } = new ObservableCollection<IExplorerItem>();

        public List<FloatingMenuItem> MenuOptions { get; private set; }

        public string ParentFolderName => _parentFolder?.Name;

        public ICommand NewFileCommand => new Command<FileType>(async (item) => await OnNewFileCommand(item));
        public ICommand NewFolderCommand => new Command(async () => await OnNewFolderCommand());
        public ICommand OptionsSelectedCommand => new Command<IExplorerItem>(async (item) => await OnOptionsSelectedCommand(item));

        private void LoadData()
        {
            Items.Clear();
            Files.Clear();
            Folders.Clear();
            FolderColors.Clear();

            JsonHelper.Instance.LoadViewModel(this, pageName: "ExplorerListPage.xaml", source: "ExplorerFlow.json");

            if (RootDirectory == null)
            {
                RootDirectory = Items;
            }

            foreach (var item in Folders)
            {
                Items.Add(item);
            }

            foreach (var item in Files)
            {
                Items.Add(item);
            }
        }

        private Task OnNewFileCommand(FileType fileType)
        {
            var popupViewModel = new NewExplorerItemPopupViewModel(fileType);
            return OpenNewExplorerItemPopup(popupViewModel);
        }

        private Task OnNewFolderCommand()
        {
            var popupViewModel = new NewExplorerItemPopupViewModel(FolderColors);
            return OpenNewExplorerItemPopup(popupViewModel);
        }

        private async Task OpenNewExplorerItemPopup(NewExplorerItemPopupViewModel vm)
        {
            var popup = new NewExplorerItemPopupTemplate(vm);
            await IPopupService.Current.PushAsync(popup);

            var explorerItem = await vm.Result.Task;
            if (explorerItem != null)
            {
                Items.Add(explorerItem);

                if (_parentFolder != null)
                {
                    if (_parentFolder.Content == null)
                    {
                        _parentFolder.Content = new List<IExplorerItem>();
                    }

                    _parentFolder.Content.Add(explorerItem);
                }
            }
        }

        private Task OnOptionsSelectedCommand(IExplorerItem item)
        {
            var popup = new ExplorerItemsActionsPopupTemplate(new ExplorerItemsActionsPopupViewModel(Items, _parentFolder, item, FolderColors));
            return IPopupService.Current.PushAsync(popup);
        }
    }
}
