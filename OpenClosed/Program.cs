namespace OpenClosed
{
    // The Open/Closed Principle states that software entities should be open for extension, but closed for modification.
    // In other words, you should be able to add new functionality to a class without modifying it.
    // this means that you should be able to add new functionality to a class without changing the existing code.
    // This is achieved by using interfaces and abstract classes 
    // Generally, you achieve this by referring to abstractions for dependencies, such as interfaces or abstract classes, rather than using concrete classes.
    // We can add the functionality by creating new classes that implement the interfaces.
    // This reduces the risk of introducing new bugs to existing code, leading to more robust software.

    internal class Program
    {
        static void Main(string[] args)
        {
            var shapeDrawer = new After.ShapeDrawer();
            shapeDrawer.DrawShape(new After.Rectangle(10, 20));
            shapeDrawer.DrawShape(new After.Square(10));
        }
    }
}
