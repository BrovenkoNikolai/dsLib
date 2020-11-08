namespace ds.test.impl.Factory
{
    /// <summary>
    /// Интерфейс фабрики плагинов.
    /// </summary>
    interface IPluginFactory
    {
        /// <summary> 
        /// Число зарегистрированных плагинов. 
        /// </summary>
        int PluginsCount { get; }

        /// <summary> 
        /// Имена зарегистрированных плагинов. 
        /// </summary>
        string[] GetPluginNames { get; }

        /// <summary> 
        /// Получить плагин по имени. 
        /// </summary>
        /// <param name="pluginName">Имя плагина, соответствует имени типа плагина.</param>
        /// <returns> Экземпляр плагина реализующий интерфейс IPlugin. </returns>
        IPlugin GetPlugin(string pluginName);
    }
}