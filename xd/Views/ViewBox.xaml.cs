using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class ViewBox : UserControl
    {
        public ViewBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}