using InterfaceSegregation.After;

namespace InterfaceSegregation
{
    // Interface Segregation Principle
    // A client should never be forced to implement an interface that it doesn't use
    // ISP states that clients should not be forced to depend on interfaces they don't use. In other words, it's better to have multiple smaller, specific interfaces rather than one large, general-purpose interface.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the better implementation
            IPrinter economicPrinter = new BetterEconomicPrinter();
            economicPrinter.Print("Simple Document");

            BetterHighEndPrinter highEndPrinter = new BetterHighEndPrinter();
            highEndPrinter.Print("Complex Document");
            highEndPrinter.Scan("Important Paper");
            highEndPrinter.PrintDuplex("Two-sided Document");
        }
    }
}
