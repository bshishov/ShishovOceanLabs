using System;
using System.Collections.Generic;

using Slb.Ocean.Core;

namespace ShishovLab1
{
    public class Plugin : Slb.Ocean.Core.Plugin
    {
        public override string AppVersion
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Shishov Boris"; }
        }

        public override string Contact
        {
            get { return "borisshishov@gmail.com"; }
        }

        public override IEnumerable<PluginIdentifier> Dependencies
        {
            get { return null; }
        }

        public override string Description
        {
            get { return ""; }
        }

        public override string ImageResourceName
        {
            get { return null; }
        }

        public override Uri PluginUri
        {
            get { return new Uri("http://shishov.no-ip.org"); }
        }

        public override IEnumerable<ModuleReference> Modules
        {
            get 
            {
                // Please fill this method with your modules with lines like this:
                //yield return new ModuleReference(typeof(Module));
                yield return new ModuleReference(typeof(Module));

            }
        }

        public override string Name
        {
            get { return "Plugin"; }
        }

        public override PluginIdentifier PluginId
        {
            get { return new PluginIdentifier(typeof(Plugin).FullName, typeof(Plugin).Assembly.GetName().Version); }
        }

        public override ModuleTrust Trust
        {
            get { return new ModuleTrust("Default"); }
        }
    }
}
