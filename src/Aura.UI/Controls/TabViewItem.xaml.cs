using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Collections;
using Avalonia.Media;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Aura.UI.Controls
{
    public class TabViewItem : HeaderedContentControl
    {
        public TabViewItem()
        {
            this.InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}