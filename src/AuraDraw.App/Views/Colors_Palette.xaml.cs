using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dock.Model.Controls;

namespace AuraDraw.App.Views
{
    public class Colors_Palette : UserControl 
    {
        public Colors_Palette()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class Colors_Palette_VM : Tool{
        
    }
}