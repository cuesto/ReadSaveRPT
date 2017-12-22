using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSaveRPT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReportDocument doc = new ReportDocument();
                doc.Load(@"C:\pendientes\ClientesHana.rpt");
                doc.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Text, @"C:\pendientes\ClientesHanaResult.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
