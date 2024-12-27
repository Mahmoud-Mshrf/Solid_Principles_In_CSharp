using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Before
{
    // This class needs all functions - OK
    public class HighEndPrinter : IMultiFunction
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Scanning: {document}");
        }

        public void Fax(string document)
        {
            Console.WriteLine($"Faxing: {document}");
        }

        public void PrintDuplex(string document)
        {
            Console.WriteLine($"Printing duplex: {document}");
        }
    }
}
