/* [grial-metadata] id: Grial#ExplorerItemsActionsPopupViewModel.cs version: 2.0.6 */

using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Popups;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ExplorerItemsActionsPopupViewModel : ObservableObject
    {
        private ObservableCollection<IExplorerItem> _directory;
        private IExplorerItem _explorerItem;
        private List<string> _folderColors;
        private IPopupPage _itemActionsPopup;
        private Folder _parentFolder;

        public ExplorerItemsActionsPopupViewModel(ObservableCollection<IExplorerItem> directory, Folder parentFolder, IExplorerItem explorerItem, List<string> folderColors)
        {
            _directory = directory;
            _explorerItem = explorerItem;
            _folderColors = folderColors;
            _parentFolder = parentFolder;

            LoadActions();
        }

        public ICommand ActionSelectedCommand => new Command<Action>(async (item) => await OnActionSelectedCommand(item));

        public List<Action> Actions { get; set; }

        public string Title => _explorerItem is Folder ? "Folder Actions" : "File Actions";

        private Task OnActionSelectedCommand(Action item)
        {
            if (item.Label == "Rename")
            {
                return OnRename();
            }
            else if (item.Label == "Color")
            {
                return OnColor();
            }
            else if (item.Label == "Move")
            {
                return OnMove();
            }
            else if (item.Label == "Copy")
            {
                return OnCopy();
            }
            else if (item.Label == "Share")
            {
                return OnShare();
            }
            else if (item.Label == "Sync")
            {
                return OnSync();
            }
            else if (item.Label == "Delete")
            {
                return OnDelete();
            }

            return IPopupService.Current.PopAsync();
        }

        private void LoadActions()
        {
            Action specialAction;
            if (_explorerItem is Folder)
            {
                specialAction = new Action { Icon = GrialIconsFont.ColorPalette, Label = "Color" };
            }
            else
            {
                specialAction = new Action { Icon = GrialIconsFont.CornerUpRight, Label = "Move" };
            }

            Actions = new List<Action>
            {
                new Action { Icon = GrialIconsFont.Edit2, Label = "Rename" },
                specialAction,
                new Action { Icon = GrialIconsFont.Copy, Label = "Copy" },
                new Action { Icon = GrialIconsFont.Share2, Label = "Share" },
                new Action { Icon = GrialIconsFont.RefreshCw, Label = "Sync" },
                new Action { Icon = GrialIconsFont.Trash2, Label = "Delete" }
            };
        }

        private async Task OnColor()
        {
            var popupViewModel = new NewExplorerItemPopupViewModel(_folderColors, _explorerItem as Folder);
            var popup = new NewExplorerItemPopupTemplate(popupViewModel);
            await OpenPopup(popup);

            var modifiedItem = await popupViewModel.Result.Task;
            if (modifiedItem != null)
            {
                _directory[_directory.IndexOf(_explorerItem)] = modifiedItem;
            }

            await ClosePopup();
        }

        private async Task OnMove()
        {
            await OpenPopup(new MoveFilePopupTemplate(new MoveFilePopupViewModel(_directory, _parentFolder, _explorerItem as File)));
            await ClosePopup();
        }

        private async Task OnRename()
        {
            var popupViewModel = new NewExplorerItemPopupViewModel(_explorerItem);
            var popup = new NewExplorerItemPopupTemplate(popupViewModel);
            await OpenPopup(popup);

            var modifiedItem = await popupViewModel.Result.Task;
            if (modifiedItem != null)
            {
                _directory[_directory.IndexOf(_explorerItem)] = modifiedItem;
            }

            await ClosePopup();
        }

        private Task OnCopy()
        {
            if (_explorerItem is Folder folder)
            {
                _directory.Add(new Folder
                {
                    Name = $"{folder.Name} copy",
                    BackgroundColor = folder.BackgroundColor,
                    Content = null,
                    CreationDate = DateTime.Now.ToString("ddd dd, yyyy")
                });
            }
            else if (_explorerItem is File file)
            {
                _directory.Add(new File
                {
                    Name = $"{file.Name} copy",
                    Type = file.Type,
                    CreationDate = DateTime.Now.ToString("ddd dd, yyyy")
                });
            }

            return ClosePopup();
        }

        private Task OnShare()
        {
            return Share.RequestAsync(new ShareTextRequest
            {
                Text = DeviceInfo.Platform == DevicePlatform.iOS ? "https://itunes.apple.com/app/grial-uikit/id1099501310" : "https://play.google.com/store/apps/details?id=uxdivers.grial",
                Title = "Download demo app"
            });
        }

        private async Task OnSync()
        {
            await OpenPopup(new SyncPopupTemplate());

            await ClosePopup();
        }

        private async Task OnDelete()
        {
            var popupViewModel = new DeleteConfirmationPopupViewModel();
            var popup = new DeleteConfirmationPopupTemplate(popupViewModel);
            await OpenPopup(popup);

            var result = await popupViewModel.Result.Task;
            if (result is bool resultAsBool && resultAsBool)
            {
                _directory.Remove(_explorerItem);
            }

            await ClosePopup();
        }

        private Task OpenPopup(IPopupPage popup)
        {
            if (_itemActionsPopup == null)
            {
                _itemActionsPopup = IPopupService.Current.NavigationStack.Last();
            }

            return IPopupService.Current.PushAsync(popup);
        }

        private Task ClosePopup()
        {
            if (_itemActionsPopup != null)
            {
                return IPopupService.Current.PopAsync(_itemActionsPopup);
            }

            return IPopupService.Current.PopAsync();
        }

        public class Action
        {
            public string Icon { get; set; }
            public string Label { get; set; }
        }
    }
}