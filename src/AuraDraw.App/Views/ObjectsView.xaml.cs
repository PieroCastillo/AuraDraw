using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class ObjectsView : UserControl
    {
        public ObjectsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}