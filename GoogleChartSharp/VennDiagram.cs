using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    public class VennDiagram : Chart
    {
        /// <summary>
        /// Create a venn diagram
        /// </summary>
        /// <param name="width">width in pixels</param>
        /// <param name="height">height in pixels</param>
        public VennDiagram(int width, int height)
            : base(width, height)
        {
        }

        protected override string urlChartType()
        {
            return "v";
        }

        protected override ChartType getChartType()
        {
            return ChartType.VennDiagram;
        }
    }
}
