using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    /// <summary>
    /// The orientation of the bars.
    /// </summary>
    public enum BarChartOrientation
    {
        /// <summary>
        /// Bars will be positioned vertically
        /// </summary>
        Vertical,

        /// <summary>
        /// Bars will be positioned horizontally
        /// </summary>
        Horizontal
    }

    /// <summary>
    /// Bar chart style when using multiple data sets
    /// </summary>
    public enum BarChartStyle
    {
        /// <summary>
        /// Multiple data sets will be stacked.
        /// </summary>
        Stacked,

        /// <summary>
        /// Multiple data sets will be grouped.
        /// </summary>
        Grouped
    }

    /// <summary>
    /// Bar Chart
    /// </summary>
    public class BarChart : Chart
    {
        BarChartOrientation orientation;
        BarChartStyle style;
        int barWidth;
        double zeroLine = 0;

        /// <summary>
        /// Create a bar chart
        /// </summary>
        /// <param name="width">Width in pixels</param>
        /// <param name="height">Height in pixels</param>
        /// <param name="orientation">The orientation of the bars.</param>
        /// <param name="style">Bar chart style when using multiple data sets</param>
        public BarChart(int width, int height, BarChartOrientation orientation, BarChartStyle style)
            : base(width, height)
        {
            this.orientation = orientation;
            this.style = style;
        }

        /// <summary>
        /// Set the width of the individual bars
        /// </summary>
        /// <param name="width">Width in pixels</param>
        public void SetBarWidth(int width)
        {
            this.barWidth = width;
        }

        /// <summary>
        /// Specify a zero line
        /// </summary>
        /// <param name="zeroLine"></param>
        public void SetZeroLine(double zeroLine)
        {
            this.zeroLine = zeroLine;
        }

        /// <summary>
        /// Return the chart identifier used in the chart url.
        /// </summary>
        /// <returns></returns>
        protected override string urlChartType()
        {
            char orientationChar = this.orientation == BarChartOrientation.Horizontal ? 'h' : 'v';
            char styleChar = this.style == BarChartStyle.Stacked ? 's' : 'g';

            return String.Format("b{0}{1}", orientationChar, styleChar);
        }

        /// <summary>
        /// Collect all the elements that will make up the chart url.
        /// </summary>
        protected override void collectUrlElements()
        {
            base.collectUrlElements();
            if (this.barWidth != 0)
            {
                base.urlElements.Enqueue(String.Format("chbh={0}", this.barWidth));
            }
            if (this.zeroLine != 0)
            {
                base.urlElements.Enqueue(String.Format("chp={0}", this.zeroLine));
            }
        }

        /// <summary>
        /// Return the chart type for this chart
        /// </summary>
        /// <returns></returns>
        protected override ChartType getChartType()
        {
            return ChartType.BarChart;
        }
    }
}
