using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Avalonia;
using Avalonia.Controls;

namespace Aura.CommonCore
{
    public interface IAppData
    {
        public void SetMainWorkSpace(TabControl tabControl);


        TabControl MainWorkSpace { get; set; }
    }
}
