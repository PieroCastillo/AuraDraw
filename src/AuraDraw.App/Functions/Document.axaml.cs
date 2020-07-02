using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;
using Avalonia.Media;
using System.Collections.Generic;
using Avalonia.Controls.Presenters;
using Aura.UI.UIExtensions;
using System.Linq.Expressions;
using Avalonia.Controls;
using Avalonia.Layout;

[assembly: XmlnsDefinition("https://github.com/avaloniaui", "AuraDraw.App.Functions")]

namespace AuraDraw.App.Functions
{
    public class Document : UserControl
    {
        protected Panel panel;

        public Document()
        {
            AvaloniaXamlLoader.Load(this);
        }
        public UnitOfMeasurement Unit
        {
            get { return GetValue(UnitProperty); }
            set { SetValue(UnitProperty, value); }
        }
        public readonly static StyledProperty<UnitOfMeasurement> UnitProperty =
            AvaloniaProperty.Register<Document, UnitOfMeasurement>(nameof(Unit),UnitOfMeasurement.Pixels);

        public string NameOfDocument
        {
            get { return GetValue(NameOfDocumentProperty); }
            set { SetValue(NameOfDocumentProperty, value); }
        }
        public readonly static StyledProperty<string> NameOfDocumentProperty =
            AvaloniaProperty.Register<Document, string>(nameof(NameOfDocument),"Document");

        public Orientation Orientation
        { 
            get { return GetValue(OrientationProperty); }
            protected set { SetValue(OrientationProperty, value); }
        }
        public readonly static StyledProperty<Orientation> OrientationProperty =
            AvaloniaProperty.Register<Document, Orientation>(nameof(Orientation),Orientation.Vertical);

        public int DocumentHeight
        {
            get { return GetValue(DocumentHeightProperty); }
            set { SetValue(DocumentHeightProperty, value); }
        }
        public readonly static StyledProperty<int> DocumentHeightProperty =
            AvaloniaProperty.Register<Document, int>(nameof(DocumentHeight));

        public int DocumentWidth
        {
            get { return GetValue(DocumentWidthProperty); }
            set { SetValue(DocumentWidthProperty, value); }
        }
        public readonly static StyledProperty<int> DocumentWidthProperty =
            AvaloniaProperty.Register<Document, int>(nameof(DocumentWidth));

        public void SwitchOrientation(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Horizontal:
                    this.Width = this.DocumentHeight;
                    this.Height = this.DocumentWidth;
                    this.Orientation = orientation;
                    break;
                case Orientation.Vertical:
                    this.Width = this.DocumentWidth;
                    this.Height = this.DocumentHeight;
                    this.Orientation = orientation;
                    break;
            }
        }

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);

            this.panel = this.GetControl<Panel>(e, "panel_");
        }

    }

    public enum Orientation
    {
        Horizontal, Vertical
    }
}


