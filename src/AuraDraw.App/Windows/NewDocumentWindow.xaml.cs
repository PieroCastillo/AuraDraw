using Aura.UI.Controls;
using Aura.UI.UIExtensions;
using AuraDraw.App.Functions;
using AuraDraw.App.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Microsoft.Toolkit.Extensions;
using System;
using System.Collections.Generic;

namespace AuraDraw.App.Windows
{
    public class NewDocumentWindow : Window
    {
        ComboBox combo_;
        TextBox textboxNameDoc;
        Button AgreeButton;
        RadioButton orientation1_;
        RadioButton orientation2_;
        TextBox H_txt;
        TextBox W_txt;
        public NewDocumentWindow()
        {
            this.InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Icon = null;
#if DEBUG
            this.AttachDevTools();
#endif
            orientation1_ = this.Find<RadioButton>("orientation1");
            orientation2_ = this.Find<RadioButton>("orientation2");
            H_txt = this.Find<TextBox>("TxtH");
            W_txt = this.Find<TextBox>("TxtW");
            combo_ = this.Find<ComboBox>("combobox_list");
            textboxNameDoc = this.Find<TextBox>("textbox_name");
            AgreeButton = this.Find<Button>("AgreeButton");
            AgreeButton.Click += AgreeButton_Click;

            combo_.PropertyChanged += Combo__PropertyChanged;
            textboxNameDoc.PropertyChanged += TextboxNameDoc_PropertyChanged;
        }

       
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public Document CreateNewDocument(TabControl WorkSpace)
        {
            var NewDoc = new Document();
            var NewDocVw = new DocumentView();
            
            
            if(combo_.SelectedItem.ToString() == "Pulgadas")
            {
                NewDoc.Unit = UnitOfMeasurement.Inches;
            }else if(combo_.SelectedItem.ToString() == "Centímetros")
            {
                NewDoc.Unit = UnitOfMeasurement.Centimeters;
            }
            else  if(combo_.SelectedItem.ToString() == "Píxeles")
            {
                NewDoc.Unit = UnitOfMeasurement.Pixels;
            }
            NewDoc.NameOfDocument = textboxNameDoc.Text;
            NewDoc.DocumentHeight = Int32.Parse(H_txt.Text);
            NewDoc.DocumentWidth = Int32.Parse(W_txt.Text);
            NewDoc.Background = Brushes.White;
            switch (orientation1_.IsChecked)
            {
                case true:
                    NewDoc.SwitchOrientation(Orientation.Vertical);
                    break;
                default:
                    NewDoc.SwitchOrientation(Orientation.Horizontal);
                    break;
            }
            
            NewDocVw.AddDocument(NewDoc);
            WorkSpace.AddTab(new AuraTabItem()
            {
                Header = NewDoc.NameOfDocument,
                Content = NewDocVw,
                IsSelected = true
            }); ;
            
            return NewDoc;
        }
    
       
        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            CreateNewDocument(AppData.MainWorkSpace);
            this.Close();
        } 
        private void TextboxNameDoc_PropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (combo_.SelectedItem != null & textboxNameDoc.Text != null & H_txt.Text.IsNumeric() == true & W_txt.Text.IsNumeric() == true)
            {
                AgreeButton.IsEnabled = true;
            }
            else { AgreeButton.IsEnabled = false; }
        }

        private void Combo__PropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (combo_.SelectedItem != null & textboxNameDoc.Text != null & H_txt.Text.IsNumeric() == true & W_txt.Text.IsNumeric() == true)
            {
                AgreeButton.IsEnabled = true;
            }
            else { AgreeButton.IsEnabled = false; }
        }

    }
}
