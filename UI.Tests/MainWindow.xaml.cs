using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Aura.UI.UIExtensions;

namespace UI.Tests
{
    public class MainWindow : Window
    {
        TabControl tabc;
        Button addbtn;
        Button cbtn;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            tabc = this.Find<TabControl>("tabview");
            addbtn = this.Find<Button>("btn");
            cbtn = this.Find<Button>("cbtn");
            addbtn.Click += Addbtn_Click;
            cbtn.Click += Cbtn_Click;
        }

        private void Cbtn_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            tabc.CloseTab(tabc.ItemCount);
        }

        private void Addbtn_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            tabc.AddTab(new TabItem() { Header = "WOW!" });
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
