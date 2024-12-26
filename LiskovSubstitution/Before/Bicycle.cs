namespace LiskovSubstitution.Before
{
    class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            throw new InvalidOperationException("Bicycles don't have engines");
        }
    }// a bicycle is a Vehicle, however, it does not have an engine and hence, startEngine() method cannot be implemented.So, it violates LSP
}
