using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace DependencyInversion
{
    // Dependency Inversion Principle
    // High-level modules should not depend on low-level modules. Both should depend on abstractions.
    // Abstractions should not depend on details. Details should depend on abstractions.
    // We used the Dependency Injection (DI) technique to implement the Dependency Inversion Principle(DIP), to apply the Open-Close Principle(OCP).
    // In this example(the example we used in OpenClosed project), the ShapeDrawer class depends on the IShape interface, which is an abstraction.
    // The Rectangle and Square classes are low-level modules that implement the IShape interface.
    // The ShapeDrawer class does not depend on the Rectangle and Square classes directly.
    // This allows us to add new shapes without changing the existing code.
    // The ShapeDrawer class is a high-level module, and the Rectangle and Square classes are low-level modules.
    // The ShapeDrawer class depends on the IShape interface, which is an abstraction.
    // The Rectangle and Square classes depend on the IShape interface as well.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Before store depends on Stripe class directly
            // var store = new Before.Store();
            // store.SellItem();
            // After
            var store = new After.Store();
            After.IPaymentGateWay IPaymentGateWay = new After.Stripe();
            // After.IPaymentGateWay IPaymentGateWay = new After.PayPal();
            // here we can change the payment processor from Stripe to PayPal without changing the Store class.
            // so it follows the Dependency Inversion Principle.
            store.SetPaymentGateWay(IPaymentGateWay);
            store.SellItem();
        }   
    }
}
