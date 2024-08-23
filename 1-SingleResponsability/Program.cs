using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper<Student> exportHelper = new();
exportHelper.ExportsStudentsCsv(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");