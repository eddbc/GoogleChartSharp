using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    /// <summary>
    /// Fill the area between / under lines
    /// </summary>
    public class FillArea
    {
        private FillAreaType type;

        private string color;
        /// <summary>
        /// an RRGGBB format hexadecimal number
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int startLineIndex;
        /// <summary>
        /// the index of the line at which the fill starts. This is determined by the order in which data sets are added. The first data set specified has an index of zero (0), the second 1, and so on.
        /// </summary>
        public int StartLineIndex
        {
            get { return startLineIndex; }
            set { startLineIndex = value; }
        }

        private int endLineIndex;
        /// <summary>
        /// the index of the line at which the fill ends. This is determined by the order in which data sets are added. The first data set specified has an index of zero (0), the second 1, and so on.
        /// </summary>
        public int EndLineIndex
        {
            get { return endLineIndex; }
            set { endLineIndex = value; }
        }

        /// <summary>
        /// Create a fill area between lines for use on a line chart.
        /// </summary>
        /// <param name="color">an RRGGBB format hexadecimal number</param>
        /// <param name="startLineIndex">line indexes are determined by the order in which datasets are added. The first set is index 0, then index 1 etc</param>
        /// <param name="endLineIndex">line indexes are determined by the order in which datasets are added. The first set is index 0, then index 1 etc</param>
        public FillArea(string color, int startLineIndex, int endLineIndex)
        {
            this.type = FillAreaType.MultiLine;
            this.color = color;
            this.startLineIndex = startLineIndex;
            this.endLineIndex = endLineIndex;
        }

        /// <summary>
        /// Fill all the area under a line
        /// </summary>
        /// <param name="color">an RRGGBB format hexadecimal number</param>
        /// <param name="lineIndex">line indexes are determined by the order in which datasets are added. The first set is index 0, then index 1 etc</param>
        public FillArea(string color, int lineIndex)
        {
            this.type = FillAreaType.SingleLine;
            this.color = color;
            this.startLineIndex = lineIndex;
        }

        internal string GetUrlString()
        {
            string s = string.Empty;

            if (type == FillAreaType.MultiLine)
            {
                s += "b" + ",";
                s += this.color + ",";
                s += this.startLineIndex.ToString() + ",";
                s += this.endLineIndex.ToString() + ",";
                s += "0"; // ignored
            }
            else if (type == FillAreaType.SingleLine)
            {
                s += "B" + ",";
                s += this.color + ",";
                s += this.startLineIndex.ToString() + ",";
                s += "0" + ","; // ignored
                s += "0"; // ignored
            }

            return s;
        }
    }

    /// <summary>
    /// Specify area fill behavior
    /// </summary>
    public enum FillAreaType
    {
        /// <summary>
        /// All area under the line will be filled
        /// </summary>
        SingleLine,

        /// <summary>
        /// The area between this line and the next will be filled
        /// </summary>
        MultiLine
    }
}
