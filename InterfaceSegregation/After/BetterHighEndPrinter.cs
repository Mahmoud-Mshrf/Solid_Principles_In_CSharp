namespace InterfaceSegregation.After
{
    // High-end printer implements all interfaces it needs
    public class BetterHighEndPrinter : IPrinter, IScanner, IFax, IDuplexPrinter
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
