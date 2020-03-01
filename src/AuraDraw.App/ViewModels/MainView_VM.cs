using Dock.Model;
using Dock.Model.Controls;

namespace AuraDraw.App.ViewModels
{
    public class MainView_VM : RootDock
    {
        public override IDockable Clone(){
            var mainViewModel = new MainView_VM();

            CloneHelper.CloneDockProperties(this, mainViewModel);
            CloneHelper.CloneRootDockProperties(this, mainViewModel);

            return mainViewModel;
        }
    }
}