namespace SingleResponsibilityAnotherExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();
        }
        static void TestWithoutSRP()
        {
            var student = new Before.Student("Mahmoud", "Cairo");
            student.Save();
        }
        static void TestWithSRP()
        {
            var student = new After.Student("Mahmoud", "Cairo");
            student.Save();
        }
    }
}
