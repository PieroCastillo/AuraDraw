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
using Aura.Maths;
using Aura.Maths.Converters;

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

        #region Properties
        public UnitsOfMeasurement Unit
        {
            get { return GetValue(UnitProperty); }
            set { SetValue(UnitProperty, value); }
        }
        public readonly static StyledProperty<UnitsOfMeasurement> UnitProperty =
            AvaloniaProperty.Register<Document, UnitsOfMeasurement>(nameof(Unit),UnitsOfMeasurement.Pixels);

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

        #endregion
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

        public void SetDocumentHeigthAndWidth(int Height_, int Width_)
        {
            var w_ = Width_;
            var h_ = Height_;
            switch (this.Unit)
            {
                case UnitsOfMeasurement.Centimeters:
                    UnitsConverter.CentimetersToPixels(w_);
                    UnitsConverter.CentimetersToPixels(h_);
                    break;
                case UnitsOfMeasurement.Inches:
                    UnitsConverter.InchesToPixels(w_);
                    UnitsConverter.InchesToPixels(h_);
                    break;
                default: break;
            }
            this.DocumentWidth = w_;
            this.DocumentHeight = h_;
        }
    }

    public enum Orientation
    {
        Horizontal, Vertical
    }
}


