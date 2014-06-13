using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class ScatterPlot : Chart
    {
        /// <summary>
        /// Create a scatter plot
        /// </summary>
        /// <param name="width">width in pixels</param>
        /// <param name="height">height in pixels</param>
        public ScatterPlot(int width, int height)
            : base(width, height)
        {

        }

        protected override string urlChartType()
        {
            return "s";
        }

        protected override ChartType getChartType()
        {
            return ChartType.ScatterPlot;
        }
    }
}
