using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class GridTests
    {
        public static string stepSizeTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Step Size Test");
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.SetData(line1);

            lineChart.SetGrid(20, 50);

            return lineChart.GetUrl();
        }

        public static string allParamsTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("All Params Test");
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.SetData(line1);

            lineChart.SetGrid(20, 50, 1, 5);

            return lineChart.GetUrl();
        }

        public static string solidGridTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Solid Grid Test");
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.SetData(line1);

            lineChart.SetGrid(20, 50, 1, 0);

            return lineChart.GetUrl();
        }
    }
}
