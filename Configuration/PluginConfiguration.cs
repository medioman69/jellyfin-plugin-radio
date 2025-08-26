using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Radio.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string RadioFolder { get; set; } = "C:\\Music\\Radio";
    }
}