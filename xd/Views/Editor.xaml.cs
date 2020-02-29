using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dock.Avalonia.Controls;

namespace AuraDraw.App.Views
{
    public class Editor : UserControl
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class Editor_VM : DocumentControl {}

    public class Editor_M {}
}