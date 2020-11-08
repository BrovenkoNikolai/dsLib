using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary>
    /// Плагин сложения чисел.
    /// </summary>
    public class PluginSum : IPlugin
    {
        /// <summary>
        /// Плагин сложения чисел.
        /// </summary>
        internal PluginSum() => Image = Properties.Resources.PluginSum;
        public string PluginName { get; } = nameof(PluginSum);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "Plugin performs addition operations.";
        public int Run(int input1, int input2) => input1 + input2;
    }
}
