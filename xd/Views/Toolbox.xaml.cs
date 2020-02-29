using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dock.Avalonia.Controls;
using Dock.Model.Controls;

namespace AuraDraw.App.Views
{
    public class Toolbox : UserControl
    {
        public Toolbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class Toolbox_VM : Tool {}

    public class Toolbox_M {}
}