using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class RangeMarker
    {
        private RangeMarkerType type;
        public RangeMarkerType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string color;
        /// <summary>
        /// an RRGGBB format hexadecimal number.
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private double startPoint;
        /// <summary>
        /// for horizontal range markers is the position on the y-axis at which the range starts where 0.00 is the bottom and 1.00 is the top.
        /// for vertical range markers is the position on the x-axis at which the range starts where 0.00 is the left and 1.00 is the right.
        /// </summary>
        public double StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        private double endPoint;
        /// <summary>
        /// for horizontal range markers is the position on the y-axis at which the range ends where 0.00 is the bottom and 1.00 is the top.
        /// for vertical range markers is the position on the x-axis at which the range ends where 0.00 is the left and 1.00 is the right.
        /// </summary>
        public double EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        /// <summary>
        /// Create a range marker for line charts and scatter plots
        /// </summary>
        /// <param name="rangeMarkerType"></param>
        /// <param name="color">an RRGGBB format hexadecimal number</param>
        /// <param name="startPoint">Must be between 0.0 and 1.0. 0.0 is axis start, 1.0 is axis end.</param>
        /// <param name="endPoint">Must be between 0.0 and 1.0. 0.0 is axis start, 1.0 is axis end.</param>
        public RangeMarker(RangeMarkerType rangeMarkerType, string color, double startPoint, double endPoint)
        {
            this.type = rangeMarkerType;
            this.color = color;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public string GetTypeUrlChar()
        {
            switch (this.type)
            {
                case RangeMarkerType.Horizontal:
                    return "r";
                case RangeMarkerType.Vertical:
                    return "R";
            }
            return null;
        }

        public string GetUrlString()
        {
            string s = string.Empty;
            s += GetTypeUrlChar() + ",";
            s += color + ",";
            // this value is ignored - but has to be a number
            s += "0" + ",";
            s += startPoint.ToString() + ",";
            s += endPoint.ToString();
            return s;
        }
    }

    public enum RangeMarkerType
    {
        /// <summary>
        /// A horizontal band across the chart area
        /// </summary>
        Horizontal,

        /// <summary>
        /// A vertical band across the chart area
        /// </summary>
        Vertical
    }
}
