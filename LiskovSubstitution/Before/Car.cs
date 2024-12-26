namespace LiskovSubstitution.Before
{
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Engine.Start();
        }
    }
}
