using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary>
    /// Плагин умножения чисел
    /// </summary>
    public class PluginMulti : IPlugin
    {
        /// <summary>
        /// Плагин умножения чисел
        /// </summary>
        internal PluginMulti() => Image = Properties.Resources.PluginMulti;
        public string PluginName { get; } = nameof(PluginMulti);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "The plugin performs multiplication operations.";
        public int Run(int input1, int input2) => input1 * input2;
    }
}
