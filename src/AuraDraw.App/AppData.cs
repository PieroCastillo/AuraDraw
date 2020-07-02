using Aura.CommonCore;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Aura.UI.UIExtensions;
using Aura.UI.Controls;
using AuraDraw.App.Windows;
using SharpDX.Direct2D1;

namespace AuraDraw.App
{
    public class AppData 
    {
        
        public static void SetMainWorkSpace(TabControl tabControl)
        {
            AppData.MainWorkSpace = tabControl;
        }
        public static TabControl MainWorkSpace 
        {
            get; 
            set; 
        }

        public static void NewDocumentOnWorkSpace(Window OwnerWindow)
        {
            var newdocwin = new NewDocumentWindow();
            newdocwin.ShowDialog(OwnerWindow);
        }

       
    }

    public enum UnitOfMeasurement
    {
        Pixels,
        Centimeters,
        Inches
    }

}
