using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using System;
using AuraDraw.App.windows;

namespace AuraDraw.App
{
    public class MainWindow : Window
    {
        Button openbtn;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
          //  DispatcherTimer timer = new DispatcherTimer();
          //  timer.Tick += new EventHandler(DispatcherTimer_Tick);
          //  timer.Interval = new TimeSpan(0,0,1);
          //  timer.Start();
          openbtn = this.Find<Button>("openbtn");
          openbtn.Click += DispatcherTimer_Tick;
            
        }
        private void InitializeComponent()
        {
            
            AvaloniaXamlLoader.Load(this);
        }

        private void DispatcherTimer_Tick(object sender,EventArgs e){
            var pwindow = new PrincipalWindow();
            pwindow.Show();
            this.Close();
        }
         
    }
}
