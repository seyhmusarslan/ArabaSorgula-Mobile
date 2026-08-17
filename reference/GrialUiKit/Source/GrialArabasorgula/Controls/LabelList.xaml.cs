/* [grial-metadata] id: Grial#LabelList.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class LabelList : ContentView
    {
        public static readonly BindableProperty SeparatorTemplateProperty = BindableProperty.Create(
           nameof(SeparatorTemplate),
           typeof(DataTemplate),
           typeof(LabelList),
           null);

        public DataTemplate SeparatorTemplate
        {
            get { return (DataTemplate)GetValue(SeparatorTemplateProperty); }
            set { SetValue(SeparatorTemplateProperty, value); }
        }

        public static readonly BindableProperty SeparatorColorProperty =
            BindableProperty.Create(
                nameof(SeparatorColor),
                typeof(Color),
                typeof(LabelList),
                defaultValue: null);

        public Color SeparatorColor
        {
            get { return (Color)GetValue(SeparatorColorProperty); }
            set { SetValue(SeparatorColorProperty, value); }
        }

        public static readonly BindableProperty SeparatorHeightProperty =
            BindableProperty.Create(
                nameof(SeparatorHeight),
                typeof(double),
                typeof(LabelList),
                defaultValue: -1d);

        public double SeparatorHeight
        {
            get { return (double)GetValue(SeparatorHeightProperty); }
            set { SetValue(SeparatorHeightProperty, value); }
        }

        public static readonly BindableProperty SpacingProperty = BindableProperty.Create(
           nameof(Spacing),
           typeof(double),
           typeof(LabelList),
           10d);

        public double Spacing
        {
            get { return (double)GetValue(SpacingProperty); }
            set { SetValue(SpacingProperty, value); }
        }

        public LabelList()
        {
            Labels = new ObservableCollection<Label>();
            Labels.CollectionChanged += OnLabelsCollectionChanged;
      
            InitializeComponent();
        }

        public ObservableCollection<Label> Labels { get; private set; }

        private void OnLabelsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (Label label in e.NewItems)
            {
                if (container.Children.Count != 0 && SeparatorTemplate?.CreateContent() is View separator)
                {
                    container.Children.Add(separator);
                }

                container.Children.Add(label);
            }
        }
    }
}
