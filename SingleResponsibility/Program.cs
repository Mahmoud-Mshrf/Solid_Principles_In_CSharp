using System.Diagnostics.Metrics;

namespace SingleResponsibility
{
    // Single Responsibility Principle (SRP)
    // A Software component should have only one reason to change.
    // A Software component should have only one responsibility.
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP(); 
            TestWithSRP();
            Console.ReadKey();
        }


        private static void TestWithoutSRP()
        {
            var account =
                new Before.Account("Mahmoud", "Mahmoud@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

        private static void TestWithSRP()
        {
            var account =
                new After.Account("Mahmoud", "Mahmoud@example.com", 10000m);

            var accountService = new After.AccountService();
            accountService.Deposit(account, 500);
            accountService.WithDraw(account, 11000);
        }


    }
}
