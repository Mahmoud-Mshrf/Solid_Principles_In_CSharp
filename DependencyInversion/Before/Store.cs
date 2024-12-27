namespace DependencyInversion.Before
{
    class Store // high-level module
    {
        private readonly Stripe stripe;
        public Store()
        {
            stripe = new Stripe();
        }
        public void SellItem()
        {
            stripe.ProcessPayment();
        }
    }
    // The Store class is a high-level module that depends on the Stripe class, which is a low-level module.
    // The Store class depends on the Stripe class directly.
    // If we want to change the payment processor from Stripe to PayPal, we need to change the Store class.
    // This violates the Dependency Inversion Principle.
}
