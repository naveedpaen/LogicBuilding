using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPrintScanPhotocopyContent
    {
        void Print(string content);
        void Scan(string content);
        void PhotoCopy(string content);
    }

    public interface IFaxContent
    {
        void Fax(string content);
    }

    public interface IDuplexContent
    {
        void Duplex(string content);
    }

}
