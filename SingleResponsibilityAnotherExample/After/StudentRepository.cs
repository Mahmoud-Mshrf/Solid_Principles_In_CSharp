namespace SingleResponsibilityAnotherExample.After
{
    internal class StudentRepository
    {
        public void Save(Student student)
        {
            // Save student to database
            Console.WriteLine("Student saved");
        }
    }
}
