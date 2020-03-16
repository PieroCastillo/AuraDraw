using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Markup.Xaml;
using Jaya.Shared.Controls;

namespace AuraDraw.App
{
    public class MainWindow : StyledWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new WindowIcon(new Bitmap(@"Assets/Logo.png"));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
           
        }
    }
}