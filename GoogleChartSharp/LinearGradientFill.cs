using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class LinearGradientFill
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
        /// specifies the angle of the gradient between 0 (horizontal) and 90 (vertical)
        /// </summary>
        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        private List<ColorOffsetPair> colorOffsetPairs = new List<ColorOffsetPair>();

        /// <summary>
        /// Create a linear gradient
        /// </summary>
        /// <param name="fillTarget">area to be filled</param>
        /// <param name="angle">specifies the angle of the gradient between 0 (horizontal) and 90 (vertical)</param>
        public LinearGradientFill(ChartFillTarget fillTarget, int angle)
        {
            this.fillTarget = fillTarget;
            this.angle = angle;
        }

        /// <summary>
        /// Add a color/offset pair to the linear gradient
        /// </summary>
        /// <param name="color">RRGGBB format hexadecimal number</param>
        /// <param name="offset">specify at what point the color is pure where: 0 specifies the right-most chart position and 1 the left-most</param>
        public void AddColorOffsetPair(string color, double offset)
        {
            this.colorOffsetPairs.Add(new ColorOffsetPair(color, offset));
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
            s += "lg,";
            s += angle.ToString() + ",";

            foreach (ColorOffsetPair colorOffsetPair in colorOffsetPairs)
            {
                s += colorOffsetPair.Color + ",";
                s += colorOffsetPair.Offset + ",";
            }

            return s.TrimEnd(",".ToCharArray());
        }

        private class ColorOffsetPair
        {
            /// <summary>
            /// RRGGBB format hexadecimal number
            /// </summary>
            public string Color;

            /// <summary>
            /// specify at what point the color is pure where: 0 specifies the right-most 
            /// chart position and 1 the left-most.
            /// </summary>
            public double Offset;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="color">RRGGBB format hexadecimal number</param>
            /// <param name="offset">specify at what point the color is pure where: 0 specifies the right-most chart position and 1 the left-most</param>
            public ColorOffsetPair(string color, double offset)
            {
                this.Color = color;
                this.Offset = offset;
            }
        }
    }
}
