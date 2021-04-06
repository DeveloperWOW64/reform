using System;

using Reform.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Reform.Views
{
    public sealed partial class ReHubDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(ReHubDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public ReHubDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ReHubDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
