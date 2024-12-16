using Week_13_DependencyInjection.ConsoleApp;

Console.WriteLine("-Öğretmen Bilgileri-");

Classroom classroom = new(new Teacher());

classroom.GetTeacherInfo();
Console.WriteLine(classroom);