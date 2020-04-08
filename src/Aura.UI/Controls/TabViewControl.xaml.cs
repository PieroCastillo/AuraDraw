using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Collections;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Aura.UI.Controls
{
    public class TabViewControl : SelectingItemsControl
    {
        public TabViewControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public new AvaloniaList<TabViewItem> Items
        {
            get { return GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }
        public new readonly StyledProperty<AvaloniaList<TabViewItem>> ItemsProperty =
            AvaloniaProperty.Register<TabViewControl, AvaloniaList<TabViewItem>>(nameof(Items));

        public int ItemsCounter
        {
            get { return this.Items.Count; }
        }
        public readonly StyledProperty<int> ItemsCounterProperty =
            AvaloniaProperty.Register<TabViewControl, int>(nameof(ItemsControl));


    }
}