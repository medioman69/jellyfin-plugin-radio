using MediaBrowser.Model.Plugins;
using MediaBrowser.Controller.Plugins;
using System.Collections.Generic;
using Jellyfin.Plugin.Radio.Configuration;

namespace Jellyfin.Plugin.Radio
{
    public class Plugin : IHasWebPages
    {
        public string Name => "Radio";
        public string Description => "Plugin per l'aggiunta di stazioni radio streaming";

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = "RadioSettings",
                    EmbeddedResourcePath = "Jellyfin.Plugin.Radio.Configuration.config.html"
                }
            };
        }
    }
}