using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace Aura.CommonCore.CommonWindows
{
    public class RecentElementsWindowxaml : Window
    {
        Button btn1;
        Button btn2;
        Button btn3;
        TextBlock texttitle;
        ListBox listrecent;
        public RecentElementsWindowxaml()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif 
            btn1 = this.Find<Button>("NewProjectsButton");
            btn2 = this.Find<Button>("ContinueWithOutAnything");
            btn3 = this.Find<Button>("OpenAnotherProject");
            texttitle = this.Find<TextBlock>("TitleWindow");
            listrecent = this.Find<ListBox>("RecentsList");

            btn1.Click += ClickOnButton1;
            btn2.Click += ClickOnButton2;
            btn3.Click += ClickOnButton3;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        #region Properties
        //btn 1 text
        public string Button1Text
        {
            get { return GetValue(Button1TextProperty); }
            set { SetValue(Button1TextProperty, value); }
        }
        public readonly static StyledProperty<string> Button1TextProperty =
            AvaloniaProperty.Register<RecentElementsWindowxaml, string>(nameof(Button1Text));
        //btn 2 text
        public string Button2Text
        {
            get { return GetValue(Button2TextProperty); }
            set { SetValue(Button2TextProperty, value); }
        }
        public readonly static StyledProperty<string> Button2TextProperty =
            AvaloniaProperty.Register<RecentElementsWindowxaml, string>(nameof(Button2Text));
        //btn 3 text 
        public string Button3Text
        {
            get { return GetValue(Button3TextProperty); }
            set { SetValue(Button3TextProperty, value); }
        }
        public readonly static StyledProperty<string> Button3TextProperty =
            AvaloniaProperty.Register<RecentElementsWindowxaml, string>(nameof(Button3Text));
        //title text
        public string TitleText
        {
            get { return GetValue(TitleTextProperty); }
            set { SetValue(TitleTextProperty, value); }
        }
        public readonly static StyledProperty<string> TitleTextProperty =
            AvaloniaProperty.Register<RecentElementsWindowxaml, string>(nameof(TitleText));
        //listcontent
        public Controls ListContent
        {
            get { return GetValue(ListContentProperty); }
            set { SetValue(ListContentProperty, value); } 
        }
        public readonly static StyledProperty<Controls> ListContentProperty =
            AvaloniaProperty.Register<RecentElementsWindowxaml, Controls>(nameof(ListContent));
        #endregion

        private void PropertyChangedThis(object sender, EventArgs e)
        {
            btn1.Content = Button1Text;
            btn2.Content = Button2Text;
            btn3.Content = Button3Text;
            texttitle.Text = TitleText;
            listrecent.Items = ListContent;
        }

        public virtual void ClickOnButton1(object sender,EventArgs e)
        {

        }
        public virtual void ClickOnButton2(object sender,EventArgs e)
        {

        }
        public virtual void ClickOnButton3(object sender,EventArgs e)
        {

        }
    }
}
