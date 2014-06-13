using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class PieChartTests
    {
        public static string TwoDTest()
        {
            int[] data = new int[] { 10, 20, 30, 40 };
            PieChart pieChart = new PieChart(250, 150);
            pieChart.SetTitle("2D Test");
            pieChart.SetData(data);
            pieChart.SetPieChartLabels(new string[] { "A", "B", "C", "D" });

            return pieChart.GetUrl();
        }

        public static string ThreeDTest()
        {
            int[] data = new int[] { 10, 20, 30, 40 };
            PieChart pieChart = new PieChart(300, 150, PieChartType.ThreeD);
            pieChart.SetTitle("3D Test");
            pieChart.SetData(data);
            pieChart.SetPieChartLabels(new string[] { "A", "B", "C", "D" });
            pieChart.SetDatasetColors(new string[] { "0000FF" });

            return pieChart.GetUrl();
        }
    }
}
