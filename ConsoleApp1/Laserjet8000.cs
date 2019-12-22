using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace ConsoleApp1
{
    class LaserJet8000 : IPrintScanPhotocopyContent, IFaxContent, IDuplexContent
    {
        public void Duplex(string content)
        {
            Console.WriteLine("Duplex Done");
        }

        public void Fax(string content)
        {
            Console.WriteLine("Fax Done");
        }

        public void PhotoCopy(string content)
        {
            Console.WriteLine("Photocopy Done");
        }

        public void Print(string content)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan Done");
            DbProviderFactories.GetFactory("");
        }
    }
}
