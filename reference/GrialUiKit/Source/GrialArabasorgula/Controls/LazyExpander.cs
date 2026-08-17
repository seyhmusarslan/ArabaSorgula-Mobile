/* [grial-metadata] id: Grial#LazyExpander.cs version: 1.0.1 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
	public class LazyExpander : CommunityToolkit.Maui.Views.Expander
	{
        public static readonly BindableProperty ContentTemplateProperty = BindableProperty.Create(
			nameof(ContentTemplate),
			typeof(ControlTemplate),
			typeof(LazyExpander));

		public ControlTemplate ContentTemplate
		{
            get { return (ControlTemplate)GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

		public LazyExpander()
		{
            ExpandedChanged += OnExpanded;
		}

        private void OnExpanded(object sender, CommunityToolkit.Maui.Core.ExpandedChangedEventArgs e)
        {
			if (IsExpanded && Content == null && ContentTemplate != null)
			{
				Content = ContentTemplate.CreateContent() as View;
			}
        }
    }
}

