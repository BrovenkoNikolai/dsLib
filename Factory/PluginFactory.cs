using ds.test.impl.OperationPlugins;
using System.Collections.Generic;

namespace ds.test.impl.Factory
{
    /// <summary> 
    /// Базовый класс для фабрики плагинов. 
    /// </summary>
    public abstract class PluginFactory : IPluginFactory
    {
        /// <summary> 
        /// Словарь зарегистрированных плагинов. 
        /// </summary>
        protected readonly Dictionary<string, IPlugin> Plugins = new Dictionary<string, IPlugin>()
        {
            {nameof(PluginSum), new PluginSum() },
            {nameof(PluginSubtrac), new PluginSubtrac() },
            {nameof(PluginMulti), new PluginMulti() },
            {nameof(PluginMin), new PluginMin() },
            {nameof(PluginMax), new PluginMax() },
            {nameof(PluginRandom), new PluginRandom() }
        };

        /// <summary> 
        /// Число зарегистрированных плагинов. 
        /// </summary>
        public abstract int PluginsCount { get; }

        /// <summary> 
        /// Имена зарегистрированных плагинов. 
        /// </summary>
        public abstract string[] GetPluginNames { get; }

        /// <summary> 
        /// Получить плагин по имени. 
        /// </summary>
        /// <param name="pluginName">Имя плагина, соответствует имени типа плагина.</param>
        /// <returns> Экземпляр плагина реализующий интерфейс IPlugin. </returns>
        public abstract IPlugin GetPlugin(string pluginName);
    }
}