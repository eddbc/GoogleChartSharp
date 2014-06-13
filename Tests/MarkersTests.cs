using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class MarkersTests
    {
        public static string rangeMarkersTest()
        {
            float[] fdata = new float[] { 10, 30, 75, 40, 15 };
            LineChart chart = new LineChart(250, 150);
            chart.SetTitle("Range markers test");
            chart.SetData(fdata);

            chart.AddAxis(new ChartAxis(ChartAxisType.Left));
            chart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            chart.AddRangeMarker(new RangeMarker(RangeMarkerType.Horizontal, "EFEFEF", 0.2, 0.7));
            chart.AddRangeMarker(new RangeMarker(RangeMarkerType.Vertical, "CCCCCC", 0.4, 0.6));

            return chart.GetUrl();
        }

        public static string shapeMarkersTest()
        {
            float[] fdata = new float[] { 10, 30, 75, 40, 15 };
            LineChart chart = new LineChart(300, 150);
            chart.SetTitle("Shape markers test");
            chart.SetData(fdata);

            chart.AddAxis(new ChartAxis(ChartAxisType.Left));
            chart.AddAxis(new ChartAxis(ChartAxisType.Bottom));

            chart.AddShapeMarker(new ShapeMarker(ShapeMarkerType.Arrow, "FF0000", 0, 0, 5));
            chart.AddShapeMarker(new ShapeMarker(ShapeMarkerType.Circle, "00FF00", 0, 1, 15));
            chart.AddShapeMarker(new ShapeMarker(ShapeMarkerType.Cross, "0000FF", 0, 2, 15));
            chart.AddShapeMarker(new ShapeMarker(ShapeMarkerType.VerticalLine, "FF0000", 0, 3, 2));

            return chart.GetUrl();
        }
    }
}
