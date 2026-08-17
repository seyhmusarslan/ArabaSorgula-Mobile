/* [grial-metadata] id: Grial#MoveFilePopupViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class MoveFilePopupViewModel : ObservableObject
    {
        private bool _isBackButtonVisible;
        private File _fileToMove;
        private Folder _currentFolder;
        private Folder _parentFolder;
        private ObservableCollection<IExplorerItem> _currentDirectory;
        private List<Folder> _items;
        private Stack<Folder> _stackNavigation;

        public MoveFilePopupViewModel(ObservableCollection<IExplorerItem> directory, Folder parentFolder, File file)
        {
            _stackNavigation = new Stack<Folder>();

            _currentDirectory = directory;
            _parentFolder = parentFolder;
            _fileToMove = file;

            Items = GetFolders(ExplorerFlowViewModel.RootDirectory);
        }

        public ICommand BackNavigationCommand => new Command(OnBackNavigationCommand);
        public ICommand ItemSelectedCommand => new Command<Folder>((item) => OnItemSelectedCommand(item));
        public ICommand MoveCommand => new Command(async () => await OnMoveCommand());
        public ICommand CloseCommand => new Command(async () => await OnCloseCommand());

        public bool IsBackButtonVisible
        {
            get => _isBackButtonVisible;
            set => SetProperty(ref _isBackButtonVisible, value);
        }

        public List<Folder> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private Task OnCloseCommand()
        {
            return IPopupService.Current.PopAsync();
        }

        private Task OnMoveCommand()
        {
            _currentDirectory.Remove(_fileToMove);

            if (_parentFolder != null)
            {
                _parentFolder.Content.Remove(_fileToMove);
            }

            if (_currentFolder == null)
            {
                if (!ExplorerFlowViewModel.RootDirectory.Contains(_fileToMove))
                {
                    ExplorerFlowViewModel.RootDirectory.Add(_fileToMove);
                }
            }
            else if (_currentFolder.Content != null)
            {
                _currentFolder.Content.Add(_fileToMove);
            }
            else
            {
                _currentFolder.Content = new List<IExplorerItem> { _fileToMove };
            }

            return IPopupService.Current.PopAsync();
        }

        private void OnItemSelectedCommand(Folder item)
        {
            if (_currentFolder != null)
            {
                _stackNavigation.Push(_currentFolder);
            }

            _currentFolder = item;

            Items = GetFolders(item.Content);

            IsBackButtonVisible = true;
        }

        private void OnBackNavigationCommand()
        {
            if (_stackNavigation.Count > 0)
            {
                _currentFolder = _stackNavigation.Pop();
                Items = GetFolders(_currentFolder.Content);
            }
            else
            {
                _currentFolder = null;
                IsBackButtonVisible = false;
                Items = GetFolders(ExplorerFlowViewModel.RootDirectory);
            }
        }

        private List<Folder> GetFolders(IEnumerable<IExplorerItem> list)
        {
            if (list != null)
            {
                return list.Where((item) => item is Folder).Cast<Folder>().ToList();
            }

            return new List<Folder>();
        }
    }
}
