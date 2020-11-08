using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Общий интерфейс для плагинов. 
    /// </summary>
    public interface IPlugin
    {
        /// <summary> Имя плагина. 
        /// </summary>
        /// <remarks> 
        /// Имя всегда соответствует имени типа плагина. 
        /// </remarks>
        string PluginName { get; }

        /// <summary> 
        /// Версия плагина. 
        /// </summary>
        string Version { get; }

        /// <summary> 
        /// Логотип плагина. 
        /// </summary>
        Image Image { get; }

        /// <summary>
        /// Описание плагина.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Операция плагина.
        /// </summary>
        /// <param name="input1"> Первый целочисленный параметр</param>
        /// <param name="input2"> Второй целочисленный параметр</param>
        /// <returns> Целочисленное число</returns>
        int Run(int input1, int input2);
    }
}
