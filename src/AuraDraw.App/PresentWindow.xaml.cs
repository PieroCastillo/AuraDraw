using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using System;
using System.Threading;
using Aura.CommonCore;
using Aura.CommonCore.CommonWindows;

namespace AuraDraw.App
{
    public class PresentWindow : Window
    {
        RecentWindowD recentWindow;
        TextBlock textversion; 
        public PresentWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif 
            textversion = this.Find<TextBlock>("textversion");
            textversion.Text = new GlobalData().GetVersion();
            var timer = new DispatcherTimer(new TimeSpan(0, 0, 5), DispatcherPriority.Loaded,new EventHandler(TimerFinish));
            timer.Start(); 
            recentWindow = new RecentWindowD();
        }

        public void TimerFinish(object sender,EventArgs e) 
        {
            recentWindow.Show();
            this.Close("Initialized Correctly");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        
    }
}
