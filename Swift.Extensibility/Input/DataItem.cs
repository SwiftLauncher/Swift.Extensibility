using System;
using System.Windows;

namespace Swift.Extensibility.Input
{
    public sealed class DataItem
    {
        public int Id { get; private set; }
        public string DisplayTitle { get; private set; }
        public string DisplaySubtitle { get; private set; }
        public ISwiftExtender Source { get; private set; }
        public FrameworkElement Content { get; private set; }
        public Action ExecutionCallback { get; private set; }

        private DataItem()
        {

        }

        public static DataItem Create(ISwiftExtender source, string displayTitle, string displaySubtitle = "", int id = 0, FrameworkElement content = null, Action executionCallback = null)
        {
            var r = new DataItem() { Source = source, Id = id, DisplayTitle = displayTitle, DisplaySubtitle = displaySubtitle, Content = content, ExecutionCallback = executionCallback };
            return r;
        }
    }
}
