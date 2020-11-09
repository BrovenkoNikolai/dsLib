using ds.test.impl.Factory;
using System;
using System.Linq;

namespace ds.test.impl
{
    /// <summary> 
    /// Фабрика плагинов. 
    /// </summary>
    public sealed class Plugins : PluginFactory
    {
        public override int PluginsCount => Plugins.Count;
        public override string[] GetPluginNames => Plugins.Keys.ToArray();

        public override IPlugin GetPlugin(string pluginName)
        {
            if (string.IsNullOrEmpty(pluginName))
            {
                throw new ArgumentNullException(nameof(pluginName));
            }
            Plugins.TryGetValue(pluginName, out var plugin);
            return plugin ?? throw new ArgumentException($"Plugin named {pluginName} is not registered!");
        }
    }
}