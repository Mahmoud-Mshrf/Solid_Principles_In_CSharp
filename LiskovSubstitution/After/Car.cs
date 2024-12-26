namespace LiskovSubstitution.After
{
    class Car : VehicleWithEngine
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }
}
