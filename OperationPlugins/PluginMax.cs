using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary>
    /// Плагин по нахождению максимального числа.
    /// </summary>
    public class PluginMax : IPlugin
    {
        /// <summary>
        /// Плагин по нахождению максимального числа.
        /// </summary>
        internal PluginMax() => Image = Properties.Resources.PluginMax;
        public string PluginName { get; } = nameof(PluginMax);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "The plugin performs a comparison operation to find the largest number.";                
        public int Run(int input1, int input2) => input1 > input2 ? input1 : input2;
    }
}