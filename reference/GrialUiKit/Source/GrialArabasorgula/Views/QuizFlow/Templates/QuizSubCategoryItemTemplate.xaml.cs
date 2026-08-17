/* [grial-metadata] id: Grial#QuizSubCategoryItemTemplate.xaml version: 1.0.4 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula;

public partial class QuizSubCategoryItemTemplate : ContentView
{
    public static readonly BindableProperty ItemTappedCommandProperty = BindableProperty.Create(
        nameof(ItemTappedCommand),
        typeof(ICommand),
        typeof(QuizSubCategoryItemTemplate));

    public ICommand ItemTappedCommand
    {
        get { return (ICommand)GetValue(ItemTappedCommandProperty); }
        set { SetValue(ItemTappedCommandProperty, value); }
    }

    public QuizSubCategoryItemTemplate()
	{
		InitializeComponent();
	}
}
