namespace InterfaceSegregation.After
{
    // Better Example - Following ISP
    public interface IPrinter
    {
        void Print(string document);
    }

    public interface IScanner
    {
        void Scan(string document);
    }

    public interface IFax
    {
        void Fax(string document);
    }

    public interface IDuplexPrinter
    {
        void PrintDuplex(string document);
    }
}