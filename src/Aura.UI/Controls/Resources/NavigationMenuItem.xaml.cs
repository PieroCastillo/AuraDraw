using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Controls.Mixins;
using System;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Aura.UI.Controls.Resources
{
    public class NavigationMenuItem : HeaderedContentControl, ISelectable
    {
        public NavigationMenuItem()
        {
            this.InitializeComponent();
        }

        public bool IsSelected
        {
            get;
            set;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public Image Icon
        {
            get { return GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly StyledProperty<Image> IconProperty =
            AvaloniaProperty.Register<NavigationMenuItem, Image>(nameof(Icon));
        
        public event EventHandler<RoutedEventArgs> Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }
        public static readonly RoutedEvent<RoutedEventArgs> ClickEvent =
          RoutedEvent.Register<Button, RoutedEventArgs>(nameof(Click), RoutingStrategies.Bubble);
    }
}
