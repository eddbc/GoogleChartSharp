using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class LineStyle
    {
        private float lineThickness;
        private float lengthOfSegment;
        private float lengthOfBlankSegment;

        /// <summary>
        /// line thickness in pixels
        /// </summary>
        public float LineThickness
        {
            get { return lineThickness; }
            set { lineThickness = value; }
        }

        /// <summary>
        /// length of each solid line segment in pixels
        /// </summary>
        public float LengthOfSegment
        {
            get { return lengthOfSegment; }
            set { lengthOfSegment = value; }
        }

        /// <summary>
        /// length of each blank line segment in pixels
        /// </summary>
        public float LengthOfBlankSegment
        {
            get { return lengthOfBlankSegment; }
            set { lengthOfBlankSegment = value; }
        }

        /// <summary>
        /// Create a line style
        /// </summary>
        /// <param name="lineThickness">line thickness in pixels</param>
        /// <param name="lengthOfSegment">length of each solid line segment in pixels</param>
        /// <param name="lengthOfBlankSegment">length of each blank line segment in pixels</param>
        public LineStyle(float lineThickness, float lengthOfSegment, float lengthOfBlankSegment)
        {
            this.lineThickness = lineThickness;
            this.lengthOfSegment = lengthOfSegment;
            this.lengthOfBlankSegment = lengthOfBlankSegment;
        }
    }
}
