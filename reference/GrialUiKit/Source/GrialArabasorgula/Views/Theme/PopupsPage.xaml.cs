/* [grial-metadata] id: Grial#PopupsPage.xaml version: 2.0.6 */

using UXDivers.Popups.Maui.Controls;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class PopupsPage : ContentPage
{
    public PopupsPage()
    {
        InitializeComponent();
    }

    private async void OpenSimpleDialog(object sender, EventArgs e)
    {
        var dialog = new SimpleDialog();
        await IPopupService.Current.PushAsync(dialog);
    }

    private async void OpenSimpleDialogNoTitle(object sender, EventArgs e)
    {
        var dialog = new SimpleDialogNoTitle();
        await IPopupService.Current.PushAsync(dialog);
    }

    private async void OpenSimpleDialogNoTitleInverse(object sender, EventArgs e)
    {
        var dialog = new SimpleDialogNoTitleInverse();
        await IPopupService.Current.PushAsync(dialog);
    }

    private async void OpenIrregularDialog(object sender, EventArgs e)
    {
        var dialog = new IrregularDialog();
        await IPopupService.Current.PushAsync(dialog);
    }

    private async void OpenNotificationPopup(object sender, System.EventArgs e)
    {
        var dialog = new NotificationPopup { Message = Resx.AppResources.StringNotificationPopupText };
        await IPopupService.Current.PushAsync(dialog);
    }

    private async void OpenCustomActionSheet(object sender, System.EventArgs e)
    {
        var dialog = new CustomActionSheet();

        // Use custom view model to display sample data
        dialog.BindingContext = new CustomActionSheetViewModel();

        await IPopupService.Current.PushAsync(dialog);
    }
    
    private async void OpenToast(object sender, EventArgs e)
    {
        var popup = new Toast()
        {
            Title = Resx.AppResources.StringToastTitle,
            IconText = GrialIconsFont.CheckCircle,
            IconColor = (Color)Application.Current.Resources["PrimaryColor"]
        };

        await IPopupService.Current.PushAsync(popup);
    }

    private async void OpenFloater(object sender, EventArgs e)
    {
        var popup = new FloaterPopup()
        {
            Title = Resx.AppResources.StringFloaterPopupTitle,
            Text = Resx.AppResources.StringFloaterPopupText,
            IconText = GrialIconsFont.CheckCircle,
            IconColor = (Color)Application.Current.Resources["PrimaryColor"]
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenSimpleText(object sender, EventArgs e)
    {
        var popup = new SimpleTextPopup()
        {
            Title = Resx.AppResources.StringSimpleTextPopupTitle,
            Text = Resx.AppResources.StringSimpleTextPopupText
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenSimpleAction(object sender, EventArgs e)
    {
        var popup = new SimpleActionPopup()
        {
            Title = Resx.AppResources.StringSimpleActionPopupTitle,
            Text = Resx.AppResources.StringSimpleActionPopupText,
            ActionButtonText = Resx.AppResources.ButtonDelete,
            SecondaryActionButtonText = Resx.AppResources.StringCancel
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenIconTextPopup(object sender, EventArgs e)
    {
        var popup = new IconTextPopup()
        {
            Title = Resx.AppResources.StringIconTextPopupTitle,
            Text = Resx.AppResources.StringIconTextPopupText,
            IconText = GrialIconsFont.CheckCircle,
            IconColor = (Color)Application.Current.Resources["PrimaryColor"],
            ActionButtonText = Resx.AppResources.StringContinue
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenImageActionSheet(object sender, EventArgs e)
    {
        var popup = new ImageActionSheet()
        {
            Title = Resx.AppResources.StringImageActionSheetTitle,
            ActionButtonText = Resx.AppResources.StringConnect,
            ShowActionButton = true
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenListActionPopup(object sender, EventArgs e)
    {
        var popup = new ListActionPopup()
        {
            Title = Resx.AppResources.StringListActionPopupTitle,
            ActionButtonText = Resx.AppResources.StringSwitch,
            ItemsSource = new List<ListActionItem>()
            {
                new ListActionItem 
                { 
                    UserImage = "user_01.jpg", 
                    User = "koston.ray", 
                    UserActivity ="1 chat - 21 notifications",
                    IsSelected = false
                }, 
                new ListActionItem 
                { 
                    UserImage = "user_02.jpg", 
                    User = "rachilly", 
                    UserActivity ="6 chat - 8 notifications",
                    IsSelected = false 
                }, 
                new ListActionItem 
                { 
                    UserImage = "user_03.jpg", 
                    User = "tommlee", 
                    UserActivity ="3 chat - 6 notifications",
                    IsSelected = true
                }
            }
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenOptionsSheet(object sender, EventArgs e)
    {
        var popup = new OptionSheetPopup
        {
            Title = Resx.AppResources.StringOptionSheetPopupTitle,
            Items = new List<OptionSheetItem>
            {
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemA,
                    GroupName = "commonActions",
                    Icon = GrialIconsFont.Copy
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemB,
                    GroupName = "commonActions",
                    Icon = GrialIconsFont.Copy
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemC,
                    GroupName = "commonActions",
                    Icon = GrialIconsFont.ArrowCircleDown
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemD,
                    GroupName = "commonActions",
                    Icon = GrialIconsFont.Image
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemF,
                    GroupName = "shareActions",
                    Icon = GrialIconsFont.MessageSquare
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemG,
                    GroupName = "shareActions",
                    Icon = GrialIconsFont.Image
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemH,
                    GroupName = "shareActions",
                    Icon = GrialIconsFont.UserPlus,
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemI,
                    GroupName = "fileActions",
                    Icon = GrialIconsFont.Printer
                },
                new OptionSheetItem
                {
                    Text = Resx.AppResources.StringOptionSheetPopupItemJ,
                    GroupName = "fileActions",
                    Icon = GrialIconsFont.Trash2,
                    IconColor = Application.Current?.Resources["ErrorColor"] as Color
                }
            }
        };

        await IPopupService.Current.PushAsync(popup);
    }
    
    private async void OpenFormPopup(object sender, EventArgs e)
    {
        var fields = new List<FormField>
        {
            new FormField
            {
                Placeholder = Resx.AppResources.StringUsername,
                Icon = "\uea22",
                IconColor = (Color)Application.Current.Resources["TextColor"]
                
            },
            new FormField
            {
                Placeholder = Resx.AppResources.StringPassword,
                Icon = "\ue98d",
                IconColor = (Color)Application.Current.Resources["TextColor"],
                IsPassword = true
            }
        };

        var popup = new FormPopup
        {
            Title = Resx.AppResources.StringFormPopupTitle,
            Text = Resx.AppResources.StringFormPopupText,
            Items = fields,
            ActionButtonText = Resx.AppResources.StringSignIn,
            SecondaryActionText = Resx.AppResources.StringFormPopupSecondaryActionText,
            SecondaryActionLinkText = Resx.AppResources.StringSignUp
        };

        List<string> result = await IPopupService.Current.PushAsync(popup);

        if (result != null && result.Count >= 2)
        {
            string email = result[0];
            string password = result[1];
            // Process login
        }
    }
    
    private async void OpenClipboardLinkPopup(object sender, EventArgs e)
    {
        var popup = new ClipboardLinkPopup
        {
            Title = Resx.AppResources.StringClipboardLinkPopupTitle,
            Text = Resx.AppResources.StringClipboardLinkPopupText,
            SecondaryActionButtonText = Resx.AppResources.StringCancel,
            ActionButtonText = Resx.AppResources.StringConfirm,
            ClipboardLinkPlaceholder = "https://samplelink"
        };

        await IPopupService.Current.PushAsync(popup);
    }

    private async void OpenSingleEntryFormPopup(object sender, EventArgs e)
    {
        var popup = new SingleEntryFormPopup
        {
            Title = Resx.AppResources.StringSingleEntryFormPopupTitle,
            Text = Resx.AppResources.StringSingleEntryFormPopupText,
            Placeholder = Resx.AppResources.StringEmail,
            ActionButtonText = Resx.AppResources.StringSubscribe
        };

        var resultEmail = await IPopupService.Current.PushAsync(popup);

        System.Console.WriteLine($"Subscribed email: {resultEmail}");
    }
    
    private async void OpenOptionsListPopup(object sender, EventArgs e)
    {
        var popup = new OptionsListPopup
        {
            Title = Resx.AppResources.StringOptionsListPopupTitle,
            Text = Resx.AppResources.StringOptionsListPopupText,
            ActionButtonText = Resx.AppResources.StringConfirm,
            SecondaryActionButtonText = Resx.AppResources.StringCancel,
            Items = new List<string>
            {
                "Share on BlueSky",
                "Share on Medium",
                "Share on Youtube"
            }
        };

        var result = await IPopupService.Current.PushAsync(popup);

        System.Console.WriteLine($"Selected option: {result}");
    }

    private async void OpenInteractiveNotificationPopup(object sender, EventArgs e)
    {
        var popup = new InteractiveNotificationPopup()
        {
            Text = Resx.AppResources.StringInteractiveNotificationPopupText,
            IconText = GrialIconsFont.CheckCircle,
            ActionButtonText = Resx.AppResources.StringUndo
        };

        await IPopupService.Current.PushAsync(popup);
    }
}

