using AuraDraw.AuraShapes;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;

namespace AuraDraw.Views
{
    public partial class EditorView : UserControl
    {
        private AuraShape currentShape;
        private IList<AuraShape> shapes;
        private bool pressed;

        public EditorView()
        {
            InitializeComponent();
            shapes = new List<AuraShape>();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);
            pressed = true;

            var line = new AuraLine();
            currentShape = line;
            line.HandleStart(e.GetPosition(this));
            line.HandleEnd(e.GetPosition(this));

            shapes.Add(line);

            InvalidateVisual();
        }
        protected override void OnPointerMoved(PointerEventArgs e)
        {
            base.OnPointerMoved(e);
            if (pressed)
            {
                var point = e.GetPosition(this);
                currentShape.HandleEnd(point);
                InvalidateVisual();
            }
        }
        protected override void OnPointerReleased(PointerReleasedEventArgs e)
        {
            base.OnPointerReleased(e);
            pressed = false;
            currentShape = null;
            InvalidateVisual();
        }

        public override void Render(DrawingContext context)
        {
            base.Render(context);

            foreach(var shape in shapes)
            {
                shape.Render(context);
            }
        }
    }
}
