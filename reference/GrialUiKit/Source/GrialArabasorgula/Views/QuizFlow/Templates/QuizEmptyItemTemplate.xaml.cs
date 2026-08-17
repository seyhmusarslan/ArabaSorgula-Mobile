/* [grial-metadata] id: Grial#QuizEmptyItemTemplate.xaml version: 1.0.4 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula;

public partial class QuizEmptyItemTemplate : ContentView
{
    public static readonly BindableProperty ReviewResultsCommandProperty = BindableProperty.Create(
        nameof(ReviewResultsCommand),
        typeof(ICommand),
        typeof(QuizEmptyItemTemplate));

    public ICommand ReviewResultsCommand
    {
        get { return (ICommand)GetValue(ReviewResultsCommandProperty); }
        set { SetValue(ReviewResultsCommandProperty, value); }
    }

    public QuizEmptyItemTemplate()
	{
		InitializeComponent();
	}
}
