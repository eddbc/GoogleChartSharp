using System;
using System.Collections.Generic;
using System.Text;
using GoogleChartSharp;

namespace Tests
{
    class VennDiagramTests
    {
        public static string VennDiagramTest()
        {
            int[] data = new int[] { 100, 80, 60, 30, 30, 30, 10 };

            VennDiagram vennDiagram = new VennDiagram(150, 150);
            vennDiagram.SetTitle("Venn Diagram");
            vennDiagram.SetData(data);

            return vennDiagram.GetUrl();
        }
    }
}
