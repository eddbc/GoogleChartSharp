using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GoogleChartSharp;
using System.Diagnostics;

namespace Tests
{
    class LineChartTests
    {
        public static string singleDatasetPerLine()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Single Dataset Per Line", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));

            return lineChart.GetUrl();
        }

        public static string sparklines()
        {
            float[] line1 = new float[] { 27, 25, 25, 25, 25, 27, 100, 31, 25, 36, 25, 25, 39, 25, 31, 25, 25, 25, 26, 26, 25, 25, 28, 25, 25, 100, 28, 27, 31, 25, 27, 27, 29, 25, 27, 26, 26, 25, 26, 26, 35, 33, 34, 25, 26, 25, 36, 25, 26, 37, 33, 33, 37, 37, 39, 25, 25, 25, 25 };

            List<float[]> dataset = new List<float[]>();
            dataset.Add(line1);

            LineChart lineChart = new LineChart(250, 150, LineChartType.Sparklines);
            lineChart.SetData(dataset);
            lineChart.SetTitle("Sparklines test");

            return lineChart.GetUrl();
        }

        public static string multiDatasetPerLine()
        {
            int[] line1x = new int[] { 0, 15, 30, 45, 60 };
            int[] line1y = new int[] { 10, 50, 15, 60, 12};
            int[] line2x = new int[] { 0, 15, 30, 45, 60 };
            int[] line2y = new int[] { 45, 12, 60, 34, 60 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1x);
            dataset.Add(line1y);
            dataset.Add(line2x);
            dataset.Add(line2y);

            LineChart lineChart = new LineChart(250, 150, LineChartType.MultiDataSet);
            lineChart.SetTitle("Multi Dataset Per Line", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));

            return lineChart.GetUrl();
        }

        public static string lineColorAndLegendTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Line Color And Legend Test", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));

            lineChart.SetDatasetColors(new string[] { "FF0000", "00FF00" });
            lineChart.SetLegend(new string[] { "line1", "line2" });

            return lineChart.GetUrl();
        }

        public static string lineStyleTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Line Style Test", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));

            lineChart.AddLineStyle(new LineStyle(2, 5, 1));
            lineChart.AddLineStyle(new LineStyle(1, 1, 5));

            return lineChart.GetUrl();
        }
    }
}
