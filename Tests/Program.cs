using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter tw = new StreamWriter(("test.html")))
            {

                #region Axes
                tw.WriteLine("<h3>Axes</h3>");
                tw.WriteLine(getImageTag(AxesTests.allBasicAxesTest()));
                tw.WriteLine(getImageTag(AxesTests.axesLabelsTest()));
                tw.WriteLine(getImageTag(AxesTests.axesRangeTest()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(AxesTests.axesStyleTest()));
                tw.WriteLine(getImageTag(AxesTests.stackedAxesTest()));
                #endregion

                # region Line Charts
                tw.WriteLine("<h3>Line Charts</h3>");
                tw.WriteLine(getImageTag(LineChartTests.singleDatasetPerLine()));
                tw.WriteLine(getImageTag(LineChartTests.multiDatasetPerLine()));
                tw.WriteLine(getImageTag(LineChartTests.lineColorAndLegendTest()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(LineChartTests.lineStyleTest()));
                tw.WriteLine(getImageTag(LineChartTests.sparklines()));
                #endregion

                #region Fills
                tw.WriteLine("<h3>Fills</h3>");
                tw.WriteLine(getImageTag(FillsTests.multiLineAreaFillsTest()));
                tw.WriteLine(getImageTag(FillsTests.singleLineAreaFillTest()));
                tw.WriteLine(getImageTag(FillsTests.linearGradientFillTest()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(FillsTests.linearStripesTest()));
                tw.WriteLine(getImageTag(FillsTests.solidFillTest()));
                #endregion

                #region Markers
                tw.WriteLine("<h3>Markers</h3>");
                tw.WriteLine(getImageTag(MarkersTests.rangeMarkersTest()));
                tw.WriteLine(getImageTag(MarkersTests.shapeMarkersTest()));

                #endregion

                #region Grids
                tw.WriteLine("<h3>Grids</h3>");
                tw.WriteLine(getImageTag(GridTests.stepSizeTest()));
                tw.WriteLine(getImageTag(GridTests.allParamsTest()));
                tw.WriteLine(getImageTag(GridTests.solidGridTest()));
                #endregion

                #region Bar Charts
                tw.WriteLine("<h3>Bar Charts</h3>");
                tw.WriteLine(getImageTag(BarChartTests.horizontalStackedTest()));
                tw.WriteLine(getImageTag(BarChartTests.verticalStackedTest()));
                tw.WriteLine(getImageTag(BarChartTests.horizontalGroupedTest()));
                tw.WriteLine(getImageTag(BarChartTests.verticalGroupedTest()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(BarChartTests.zeroLineTest()));
                #endregion

                #region Pie Charts
                tw.WriteLine("<h3>Pie Charts</h3>");
                tw.WriteLine(getImageTag(PieChartTests.TwoDTest()));
                tw.WriteLine(getImageTag(PieChartTests.ThreeDTest()));
                #endregion

                # region Venn Diagrams
                tw.WriteLine("<h3>Venn Diagrams</h3>");
                tw.WriteLine(getImageTag(VennDiagramTests.VennDiagramTest()));
                #endregion

                # region Scatter Plots
                tw.WriteLine("<h3>Scatter Plots</h3>");
                tw.WriteLine(getImageTag(ScatterPlotTests.scatterPlotTest()));
                #endregion

                #region Examples
                tw.WriteLine("<h3>Examples</h3>");
                tw.WriteLine(getImageTag(Examples.simpleAxis()));
                tw.WriteLine(getImageTag(Examples.axisLabels()));
                tw.WriteLine(getImageTag(Examples.axisRange()));
                tw.WriteLine(getImageTag(Examples.stackingAxes()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(Examples.xkcd()));
                tw.WriteLine("<br />");
                tw.WriteLine(getImageTag(Examples.superSimple()));
                #endregion
            }

            Process.Start(new FileInfo("test.html").FullName);
        }

        static string getImageTag(string url)
        {
            return "<img src=\"" + url + "\" />";
        }
    }
}
