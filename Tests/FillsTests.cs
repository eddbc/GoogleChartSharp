using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class FillsTests
    {
        public static string solidFillTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Solid fill test");
            lineChart.SetData(line1);

            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            SolidFill bgFill = new SolidFill(ChartFillTarget.Background, "EFEFEF");
            SolidFill chartAreaFill = new SolidFill(ChartFillTarget.ChartArea, "000000");

            lineChart.AddSolidFill(bgFill);
            lineChart.AddSolidFill(chartAreaFill);

            return lineChart.GetUrl();
        }

        public static string linearGradientFillTest()
        {
            int[] line1 = new int[] { 5, 10, 50, 34, 10, 25 };
            LineChart lineChart = new LineChart(250, 150);
            lineChart.SetTitle("Linear Gradient fill test");
            lineChart.SetData(line1);

            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            LinearGradientFill fill = new LinearGradientFill(ChartFillTarget.ChartArea, 45);
            fill.AddColorOffsetPair("FFFFFF", 0);
            fill.AddColorOffsetPair("76A4FB", 0.75);

            SolidFill bgFill = new SolidFill(ChartFillTarget.Background, "EFEFEF");

            lineChart.AddLinearGradientFill(fill);
            lineChart.AddSolidFill(bgFill);

            return lineChart.GetUrl();
        }

        public static string linearStripesTest()
        {
            float[] fdata = new float[] { 10, 30, 75, 40, 15 };
            LineChart chart = new LineChart(250, 150);
            chart.SetTitle("Linear Stripes Test");
            chart.SetData(fdata);

            chart.AddAxis(new ChartAxis(ChartAxisType.Left));
            chart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            LinearStripesFill linearStripesFill = new LinearStripesFill(ChartFillTarget.ChartArea, 0);
            linearStripesFill.AddColorWidthPair("CCCCCC", 0.2);
            linearStripesFill.AddColorWidthPair("FFFFFF", 0.2);
            chart.AddLinearStripesFill(linearStripesFill);

            chart.AddSolidFill(new SolidFill(ChartFillTarget.Background, "EFEFEF"));
            
            return chart.GetUrl();
        }

        public static string singleLineAreaFillTest()
        {
            float[] fdata = new float[] { 10, 30, 75, 40, 15 };
            LineChart chart = new LineChart(250, 150);
            chart.SetTitle("Area fill test");
            chart.SetData(fdata);

            chart.AddAxis(new ChartAxis(ChartAxisType.Left));
            chart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            chart.AddFillArea(new FillArea("224499", 0));
            
            return chart.GetUrl();
        }

        public static string multiLineAreaFillsTest()
        {
            float[] line1 = new float[] { 15, 45, 5, 30, 10 };
            float[] line2 = new float[] { 35, 65, 25, 50, 30 };
            float[] line3 = new float[] { 55, 85, 45, 70, 50 };

            List<float[]> dataset = new List<float[]>();
            dataset.Add(line1);
            dataset.Add(line2);
            dataset.Add(line3);

            LineChart lineChart = new LineChart(250, 150, LineChartType.SingleDataSet);
            lineChart.SetTitle("Area fills test");
            lineChart.SetData(dataset);

            lineChart.AddAxis(new ChartAxis(ChartAxisType.Left));
            lineChart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            lineChart.AddFillArea(new FillArea("FF0000", 0, 1));
            lineChart.AddFillArea(new FillArea("224499", 1, 2));

            return lineChart.GetUrl();
        }

    }
}
