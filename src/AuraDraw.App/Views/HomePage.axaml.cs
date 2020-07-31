using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace AuraDraw.App.Views
{
    /*Deciding if this's going to be using or not */
    public class HomePage : UserControl
    {
        TextBlock textoftime_;
        public HomePage()
        {
            InitializeComponent();

            textoftime_ = this.Find<TextBlock>("time_txt");

            int hw = DateTime.Now.TimeOfDay.Hours;
            if (hw < 12 | hw == 0)
            {
                textoftime_.Text = "Buenos Días";
            } else if (hw == 12 | hw < 18 )
            {
                textoftime_.Text = "Buenas Tardes";
            } else if (hw == 18 | hw < 24)
            {
                textoftime_.Text = "Buenas Noches";
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
