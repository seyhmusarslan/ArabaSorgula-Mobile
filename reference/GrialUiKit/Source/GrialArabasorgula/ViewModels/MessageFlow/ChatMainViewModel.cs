/* [grial-metadata] id: Grial#ChatMainViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ChatMainViewModel : ObservableObject
    {
        public ChatMainViewModel()
        {
            LoadData();
        }

        public ObservableCollection<FlowContactData> Contacts { get; } = new ObservableCollection<FlowContactData>();
        public ObservableCollection<FlowConversationData> Conversations { get; } = new ObservableCollection<FlowConversationData>();

        private void LoadData()
        {
            Contacts.Clear();
            Conversations.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "MessageFlow.json");
        }
    }
}
