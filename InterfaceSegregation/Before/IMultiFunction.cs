namespace InterfaceSegregation.Before
{
    // Bad Example - Violating ISP
    public interface IMultiFunction
    {
        void Print(string document);
        void Scan(string document);
        void Fax(string document);
        void PrintDuplex(string document);
    }
}