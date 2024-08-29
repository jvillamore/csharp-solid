using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository studentRepository;
    ILogbook logbook;

    public StudentController(IStudentRepository student, ILogbook log)
    {
        studentRepository = student;
        logbook = log;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public Student Add([FromBody] Student student)
    {
        logbook.Add($"The Student {student.Fullname} have been added");
        Console.WriteLine("student" + (student is not null) + " esta implementado " + (studentRepository is not null));
        var respuesta = studentRepository.Add(student);
        Console.WriteLine("RRR: " + respuesta);
        return respuesta;
    }
}
