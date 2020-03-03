using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ThemeEditor.Controls.ColorPicker;

namespace AuraDraw.App.Views
{
    public class ColorSelector : UserControl
    {
        public ColorSelector()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
