using Dock.Model.Controls;
using Dock.Model;
using Dock.Avalonia.Controls;
using AuraDraw.App.Views;

namespace AuraDraw.App
{
    public class MainDockFactory : Factory
    {
        private object _context;

        public MainDockFactory(object context)
        {
            _context = context;
        }

        public override IDock CreateLayout(){

            var Colors_Palette = new Colors_Palette_VM();
            var Editor = new Editor_VM();
            var Objects_Box = new Objects_Box_VM();
            var Objects_View = new Objects_View_VM();
            var ToolBox = new Toolbox_VM();
            return null;
        }
    }
}