using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityGoodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IExporter exporter = new PdfExporter();
            Document doc = new Document();
            doc.Text = "Hello Wolrd";
            doc.Export(exporter);
        }
    }
}
