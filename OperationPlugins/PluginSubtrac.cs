using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary>
    /// Плагин вычитания второго числа из первого.
    /// </summary>
    public class PluginSubtrac : IPlugin
    {
        /// <summary>
        /// Плагин вычитания второго числа из первого.
        /// </summary>
        internal PluginSubtrac() => Image = Properties.Resources.PluginSubtrac;
        public string PluginName { get; } = nameof(PluginSubtrac);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "The plugin performs the operation of subtracting the second from the first number.";
        public int Run(int input1, int input2) => input1 - input2;
    }
}
