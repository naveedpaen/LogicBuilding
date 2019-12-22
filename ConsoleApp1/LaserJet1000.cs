using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LaserJet1000 : IPrintScanPhotocopyContent
    {
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
        }
    }
}
