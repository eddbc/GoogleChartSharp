using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class AxesTests
    {
        public static string allBasicAxesTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Basic Axes Test", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Right));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Top));

            return lineChart.GetUrl();
        }

        public static string axesLabelsTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Axis Labels Test", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom, new string[] { "b", "o", "t", "t", "o", "m" }));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left, new string[] { "l", "e", "f", "t" }));

            ChartAxis rightAxis = new ChartAxis(ChartAxisType.Right);
            rightAxis.AddLabel(new ChartAxisLabel("r"));
            rightAxis.AddLabel(new ChartAxisLabel("i"));
            rightAxis.AddLabel(new ChartAxisLabel("g"));
            rightAxis.AddLabel(new ChartAxisLabel("h"));
            rightAxis.AddLabel(new ChartAxisLabel("t"));
            lineChart.AddAxis(rightAxis);

            ChartAxis topAxis = new ChartAxis(ChartAxisType.Top);
            topAxis.AddLabel(new ChartAxisLabel("t"));
            topAxis.AddLabel(new ChartAxisLabel("o"));
            topAxis.AddLabel(new ChartAxisLabel("p"));
            lineChart.AddAxis(topAxis);

            return lineChart.GetUrl();
        }

        public static string axesRangeTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Axes Range Test", "0000FF", 14);
            lineChart.SetData(dataset);

            ChartAxis topAxis = new ChartAxis(ChartAxisType.Top);
            topAxis.SetRange(0, 10);
            lineChart.AddAxis(topAxis);

            ChartAxis rightAxis = new ChartAxis(ChartAxisType.Right);
            rightAxis.SetRange(0, 10);
            lineChart.AddAxis(rightAxis);

            ChartAxis bottomAxis = new ChartAxis(ChartAxisType.Bottom);
            bottomAxis.SetRange(0, 10);
            lineChart.AddAxis(bottomAxis);

            ChartAxis leftAxis = new ChartAxis(ChartAxisType.Left);
            leftAxis.SetRange(0, 10);
            lineChart.AddAxis(leftAxis);

            return lineChart.GetUrl();
        }

        public static string axesStyleTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Axes Style Test", "0000FF", 14);
            lineChart.SetData(dataset);

            ChartAxis topAxis = new ChartAxis(ChartAxisType.Top);
            topAxis.SetRange(0, 10);
            topAxis.AddLabel(new ChartAxisLabel("test", 2));
            topAxis.AddLabel(new ChartAxisLabel("test", 6));
            topAxis.FontSize = 12;
            topAxis.Color = "FF0000";
            topAxis.Alignment = AxisAlignmentType.Left;
            lineChart.AddAxis(topAxis);

            ChartAxis bottomAxis = new ChartAxis(ChartAxisType.Bottom);
            bottomAxis.AddLabel(new ChartAxisLabel("test", 2));
            bottomAxis.AddLabel(new ChartAxisLabel("test", 6));
            bottomAxis.SetRange(0, 10);
            bottomAxis.FontSize = 14;
            bottomAxis.Color = "00FF00";
            bottomAxis.Alignment = AxisAlignmentType.Right;
            lineChart.AddAxis(bottomAxis);

            return lineChart.GetUrl();
        }

        public static string stackedAxesTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            int[] line2 = new int[] { 15, 20, 60, 44, 20, 35 };

            List<int[]> dataset = new List<int[]>();
            dataset.Add(line1);
            dataset.Add(line2);

            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Stacked Axes Test", "0000FF", 14);
            lineChart.SetData(dataset);
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            return lineChart.GetUrl();
        }
    }
}
