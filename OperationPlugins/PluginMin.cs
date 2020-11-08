using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary>
    /// Плагин по нахождению минимального числа.
    /// </summary>
    public class PluginMin : IPlugin
    {
        /// <summary>
        /// Плагин по нахождению минимального числа.
        /// </summary>
        internal PluginMin() => Image = Properties.Resources.PluginMin;
        public string PluginName { get; } = nameof(PluginMin);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "The plugin performs a comparison operation to find the smallest number.";
        public int Run(int input1, int input2) => input1 < input2 ? input1 : input2;
    }
}
