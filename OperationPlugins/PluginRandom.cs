using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins
{
    /// <summary> 
    /// Плагин рандомных чисел в диапазоне. 
    /// </summary>
    public class PluginRandom : IPlugin
    {
        /// <summary> 
        /// Плагин рандомных чисел в диапазоне. 
        /// </summary>
        internal PluginRandom() => Image = Properties.Resources.PluginRandom;
        private readonly Random _rnd = new Random();
        public string PluginName { get; } = nameof(PluginRandom);
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "The plugin performs a random selection of a number from a range of given numbers.";
        public int Run(int input1, int input2)
        {
            return input1 >= input2
                ? throw new Exception(
                    $"Value {nameof(input1)} cannot be greater than or equal to {nameof(input2)}.")
                : _rnd.Next(input1, input2 + 1);
        }
    }
}
