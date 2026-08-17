/* [grial-metadata] id: Grial#ExplorerFlowData.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public enum FileType
    {
        Word,
        PowerPoint,
        Excel
    }

    public interface IExplorerItem
    {
        string Name { get; set; }
        string CreationDate { get; set; }
    }

    public class Folder : IExplorerItem
    {
        public string Name { get; set; }
        public string BackgroundColor { get; set; }
        public string CreationDate { get; set; }
        public List<IExplorerItem> Content { get; set; }

        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class File : IExplorerItem
    {
        public FileType Type { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
    }
}
