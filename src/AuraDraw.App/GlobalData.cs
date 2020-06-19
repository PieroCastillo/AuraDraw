using System;
using System.Collections.Generic;
using System.Text;
using Aura.CommonCore;

namespace AuraDraw.App
{
    public class GlobalData : IGlobalDataApps
    {

        public string GetVersion()
        {
            return "0.0.0.1";
        }

        public string GetName() 
        {
            return "AuraDraw";
        }

    }
}
