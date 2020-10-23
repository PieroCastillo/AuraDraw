using Aura.UI.Controls;
using AuraDraw.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuraDraw.Managers
{
    public static class TabManager
    {
        public static AuraTabItem CreateHomeView()
        {
            var t_ = new AuraTabItem();
            t_.Header = "Home Page";
            t_.IsClosable = false;
            var hom_ = new HomeView();
            t_.Content = hom_;
            return t_;
        }
    }
}
