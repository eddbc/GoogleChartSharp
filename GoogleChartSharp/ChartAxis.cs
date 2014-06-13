using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    /// <summary>
    /// Axis label alignment. By default: x-axis labels are centered, left y-axis 
    /// labels are right aligned, right y-axis labels are left aligned
    /// </summary>
    public enum AxisAlignmentType
    {
        /// <summary>
        /// Left align label
        /// </summary>
        Left,

        /// <summary>
        /// Center align label
        /// </summary>
        Centered,

        /// <summary>
        /// Right align label
        /// </summary>
        Right,

        /// <summary>
        /// Use default alignment
        /// </summary>
        Unset
    }

    /// <summary>
    /// Chart Axis
    /// </summary>
    public class ChartAxis
    {
        ChartAxisType axisType;
        List<ChartAxisLabel> axisLabels = new List<ChartAxisLabel>();
        int upperBound;
        int lowerBound;
        bool rangeSet;
        string color;
        int fontSize = -1;
        AxisAlignmentType alignment = AxisAlignmentType.Unset;

        #region Properties
        /// <summary>
        /// an RRGGBB format hexadecimal number
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// optional if used this specifies the size in pixels
        /// </summary>
        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        /// <summary>
        /// By default: x-axis labels are centered, left y-axis labels are right aligned, right y-axis labels are left aligned
        /// </summary>
        public AxisAlignmentType Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        #endregion

        /// <summary>
        /// Create an axis, default is range 0 - 100 evenly spaced. You can create multiple axes of the same ChartAxisType.
        /// </summary>
        /// <param name="axisType">Axis position</param>
        public ChartAxis(ChartAxisType axisType) : this(axisType, null)
        {
        }

        /// <summary>
        /// Create an axis, default is range 0 - 100 evenly spaced. You can create multiple axes of the same ChartAxisType.
        /// </summary>
        /// <param name="axisType">Axis position</param>
        /// <param name="labels">These labels will be added to the axis without position information</param>
        public ChartAxis(ChartAxisType axisType, string[] labels)
        {
            this.axisType = axisType;

            if (labels != null)
            {
                foreach (string label in labels)
                {
                    this.axisLabels.Add(new ChartAxisLabel(label, -1));
                }
            }
        }

        /// <summary>
        /// Specify the axis range
        /// </summary>
        /// <param name="lowerBound">the lowest value on the axis</param>
        /// <param name="upperBound">the highest value on the axis</param>
        public void SetRange(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.rangeSet = true;
        }

        /// <summary>
        /// Add a label to the axis
        /// </summary>
        /// <param name="axisLabel"></param>
        public void AddLabel(ChartAxisLabel axisLabel)
        {
            axisLabels.Add(axisLabel);
        }

        internal string UrlAxisStyle()
        {
            if (color == null)
            {
                return null;
            }
            string result = color + ",";
            if (fontSize != -1)
            {
                result += fontSize.ToString() + ",";
            }

            if (alignment != AxisAlignmentType.Unset)
            {
                switch (alignment)
                {
                    case AxisAlignmentType.Left:
                        result += "-1,";
                        break;
                    case AxisAlignmentType.Centered:
                        result += "0,";
                        break;
                    case AxisAlignmentType.Right:
                        result += "1,";
                        break;
                }
            }

            return result.TrimEnd(",".ToCharArray());
        }

        internal string urlAxisType()
        {
            switch (axisType)
            {
                case ChartAxisType.Bottom:
                    return "x";

                case ChartAxisType.Top:
                    return "t";

                case ChartAxisType.Left:
                    return "y";

                case ChartAxisType.Right:
                    return "r";
            }

            return null;
        }

        internal string urlLabels()
        {
            string result = "|";
            foreach (ChartAxisLabel label in axisLabels)
            {
                result += label.Text + "|";
            }
            return result;
        }

        internal string urlLabelPositions()
        {
            string result = string.Empty;
            foreach (ChartAxisLabel axisLabel in axisLabels)
            {
                if (axisLabel.Position == -1)
                {
                    return null;
                }
                result += axisLabel.Position.ToString() + ",";
            }
            return result.TrimEnd(",".ToCharArray());
        }

        internal string urlRange()
        {
            if (rangeSet)
            {
                return lowerBound.ToString() + "," + upperBound.ToString();
            }
            return null;
        }
    }

    /// <summary>
    /// Describes an axis label
    /// </summary>
    public class ChartAxisLabel
    {
        /// <summary>
        /// This text will be displayed on the axis
        /// </summary>
        public string Text;

        /// <summary>
        /// A value within the axis range
        /// </summary>
        public float Position;

        /// <summary>
        /// Create an axis label without position information, labels will be evenly spaced on the axis
        /// </summary>
        /// <param name="text">The label text</param>
        public ChartAxisLabel(string text)
            : this(text, -1)
        {
        }

        /// <summary>
        /// Create an axis label without label text. The axis label will be evenly spaced on the axis and the text will
        /// be it's numeric position within the axis range.
        /// </summary>
        /// <param name="position"></param>
        public ChartAxisLabel(float position)
            : this(null, position)
        {

        }

        /// <summary>
        /// Create an axis label with label text and position.
        /// </summary>
        /// <param name="text">The label text</param>
        /// <param name="position">The label position within the axis range</param>
        public ChartAxisLabel(string text, float position)
        {
            this.Text = text;
            this.Position = position;
        }
    }

    /// <summary>
    /// Chart axis locations
    /// </summary>
    public enum ChartAxisType
    {
        /// <summary>
        /// Bottom x-axis
        /// </summary>
        Bottom,

        /// <summary>
        /// Top x-axis
        /// </summary>
        Top,

        /// <summary>
        /// Left y-axis
        /// </summary>
        Left,

        /// <summary>
        /// Right y-axis
        /// </summary>
        Right
    }
}
