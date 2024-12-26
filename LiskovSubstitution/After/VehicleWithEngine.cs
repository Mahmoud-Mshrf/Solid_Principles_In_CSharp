namespace LiskovSubstitution.After
{
    abstract class VehicleWithEngine : Vehicle
    {
        public Engine Engine { get; set; }
        public abstract void StartEngine();
    }
}
