using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class LinearStripesFill
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

        private int angle;
        /// <summary>
        /// specifies the angle of the gradient between 0 (vertical) and 90 (horizontal)
        /// </summary>
        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        private List<ColorWidthPair> colorWidthPairs = new List<ColorWidthPair>();

        /// <summary>
        /// Create a linear stripes fill.
        /// </summary>
        /// <param name="fillTarget">The area that will be filled.</param>
        /// <param name="angle">specifies the angle of the gradient between 0 (vertical) and 90 (horizontal)</param>
        public LinearStripesFill(ChartFillTarget fillTarget, int angle)
        {
            this.fillTarget = fillTarget;
            this.angle = angle;
        }

        /// <summary>
        /// A color/width pair describes a linear stripe.
        /// </summary>
        /// <param name="color">RRGGBB format hexadecimal number</param>
        /// <param name="width">must be between 0 and 1 where 1 is the full width of the chart</param>
        public void AddColorWidthPair(string color, double width)
        {
            this.colorWidthPairs.Add(new ColorWidthPair(color, width));
        }

        internal string getTypeUrlChar()
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

        internal String GetUrlString()
        {
            string s = string.Empty;
            s += getTypeUrlChar() + ",";
            s += "ls,";
            s += angle.ToString() + ",";

            foreach (ColorWidthPair colorWidthPair in colorWidthPairs)
            {
                s += colorWidthPair.Color + ",";
                s += colorWidthPair.Width + ",";
            }

            return s.TrimEnd(",".ToCharArray());
        }

        private class ColorWidthPair
        {
            /// <summary>
            /// RRGGBB format hexadecimal number
            /// </summary>
            public string Color;

            /// <summary>
            /// must be between 0 and 1 where 1 is the full width of the chart
            /// </summary>
            public double Width;

            /// <summary>
            /// Describes a linear stripe. Stripes are repeated until the chart is filled.
            /// </summary>
            /// <param name="color">RGGBB format hexadecimal number</param>
            /// <param name="width">must be between 0 and 1 where 1 is the full width of the chart</param>
            public ColorWidthPair(string color, double width)
            {
                this.Color = color;
                this.Width = width;
            }
        }
    }
}
