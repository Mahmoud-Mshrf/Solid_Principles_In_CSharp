namespace LiskovSubstitution.After
{
    class Bicycle : VehicleWithoutEngine
    {
        public override void StartMoving()
        {
            Console.WriteLine("Pedal started");
        }
    }
}
