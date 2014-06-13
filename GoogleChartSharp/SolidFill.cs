using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class SolidFill
    {
        private ChartFillTarget fillTarget;
        /// <summary>
        /// The area that will be filled.
        /// </summary>
        public ChartFillTarget FillTarget
        {
            get { return fillTarget; }
            set { fillTarget = value; }
        }

        private string color;
        /// <summary>
        /// an RRGGBB format hexadecimal number
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Create a solid fill
        /// </summary>
        /// <param name="fillTarget">The area that will be filled.</param>
        /// <param name="color">an RRGGBB format hexadecimal number</param>
        public SolidFill(ChartFillTarget fillTarget, string color)
        {
            this.fillTarget = fillTarget;
            this.color = color;
        }

        private string GetTypeUrlChar()
        {
            switch (fillTarget)
            {
                case ChartFillTarget.ChartArea:
                    return "c";
                case ChartFillTarget.Background:
                    return "bg";
            }
            return null;
        }

        public string GetUrlString()
        {
            string s = string.Empty;
            s += GetTypeUrlChar() + ",";
            s += "s,";
            s += this.color;
            return s;
        }
    }

    public enum ChartFillTarget
    {
        /// <summary>
        /// Fill the entire background of the chart
        /// </summary>
        Background,

        /// <summary>
        /// Fill only the chart area of the chart
        /// </summary>
        ChartArea
    }
}
