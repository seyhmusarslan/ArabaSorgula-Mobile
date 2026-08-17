/* [grial-metadata] id: Grial#DeleteConfirmationPopupViewModel.cs version: 1.1.6 */

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DeleteConfirmationPopupViewModel
    {
        public DeleteConfirmationPopupViewModel()
        {
        }

        public TaskCompletionSource<bool> Result { get; } = new TaskCompletionSource<bool>();

        public ICommand DeleteCommand => new Command(async () => await OnDeleteCommand());

        public ICommand CancelCommand => new Command(async () => await OnCancelCommand());

        private Task OnDeleteCommand()
        {
            Result.TrySetResult(true);
            return IPopupService.Current.PopAsync();
        }

        private Task OnCancelCommand()
        {
            Result.TrySetResult(false);
            return IPopupService.Current.PopAsync();
        }
    }
}
