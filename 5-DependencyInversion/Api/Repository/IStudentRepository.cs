namespace DependencyInversion
{
    public interface IStudentRepository
    {
        Student Add(Student student);
        IEnumerable<Student> GetAll();

    }
}