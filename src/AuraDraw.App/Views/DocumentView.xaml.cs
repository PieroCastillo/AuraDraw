using AuraDraw.App.Functions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class DocumentView : UserControl
    {
        ScrollViewer scroll_vw;
        public DocumentView()
        {
            this.InitializeComponent();

            scroll_vw = this.Find<ScrollViewer>("scrollvw_");
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void AddDocument(Document document)
        {
            this.DocumentInUse = document;
            scroll_vw.Content = document;
        }

        public Document DocumentInUse
        {
            get { return GetValue(DocumentInUseProperty); }
            protected set { SetValue(DocumentInUseProperty, value); }
        }
        public readonly static StyledProperty<Document> DocumentInUseProperty =
            AvaloniaProperty.Register<DocumentView, Document>(nameof(DocumentInUse),null);

        public static Control SelectedObject
        {
            get;
            set;
        }
    }
}
