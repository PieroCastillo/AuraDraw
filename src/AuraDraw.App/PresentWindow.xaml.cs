using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using System;
using System.Threading;

namespace AuraDraw.App
{
    public class PresentWindow : Window
    {
        MainWindow mainWindow;
        TextBlock textversion; 
        public PresentWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            textversion = this.Find<TextBlock>("textversion");
            textversion.Text = GlobalData.GetVersion();
            mainWindow = new MainWindow();
            var timer = new DispatcherTimer(new TimeSpan(0, 0, 5), DispatcherPriority.Loaded,new EventHandler(TimerFinish));
            timer.Start();
        }

        public void TimerFinish(object sender,EventArgs e) 
        {
            mainWindow.Show();
            this.Close("Initialized Correctly");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        
    }
}
