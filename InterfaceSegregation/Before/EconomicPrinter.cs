namespace InterfaceSegregation.Before
{
    // This class is forced to implement unnecessary methods - Bad
    public class EconomicPrinter : IMultiFunction
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void Scan(string document)
        {
            throw new NotImplementedException("Economic printer cannot scan!");
        }

        public void Fax(string document)
        {
            throw new NotImplementedException("Economic printer cannot fax!");
        }

        public void PrintDuplex(string document)
        {
            throw new NotImplementedException("Economic printer cannot print duplex!");
        }
    }
}
