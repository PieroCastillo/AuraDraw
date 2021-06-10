using AuraDraw.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Presenters;
using Avalonia.Markup.Xaml.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuraDraw.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static string title_;
        public string Title { get => GetTitle(); }
        
        public double MaxWidthOfTabManager 
        { 
            get
            {
                var win = ((Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)).MainWindow as MainWindow;
                if(win != null)
                {
                    return win.Width - 30;
                }
                else
                {
                    return Double.NaN;
                }
            }
        }

    

        private string GetTitle()
        {
            return MainWindowViewModel.title_;
        }

        public static void SetTitle(string title)
        {
            MainWindowViewModel.title_ = title;
        }


    }
}