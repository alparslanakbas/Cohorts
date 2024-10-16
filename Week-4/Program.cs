using Week_4.Models;

// Bu örnek pek de OOP ye uyum sağlamıyor çünkü person da hem öğretmen hem de öğrenci tutuyoruz sağlıklı değil
//Person personStudent = new()
//{
//    Name = "Alparslan",
//    Surname = "Akbaş",
//    BirthDate = new DateTime(1999, 01, 03),
//    IsStudent = true
//};

//Console.WriteLine
//    (
//        $"Öğrenci Bilgileri \n"
//        + $"Name: {personStudent.Name} \n"
//        + $"Surname: {personStudent.Surname} \n"
//        + $"BirthDate: {personStudent.BirthDate.ToLongDateString()} \n"
//        + $"IsStudent: {personStudent.IsStudent}"
//    );

//Console.WriteLine();

//Person personTeacher = new()
//{
//    Name = "Hasan ali veli",
//    Surname = "deli",
//    BirthDate = new DateTime(1980, 01, 03),
//    IsTeacher = true
//};

//Console.WriteLine
//    (
//        $"Öğretmen Bilgileri \n"
//        + $"Name: {personTeacher.Name} \n"
//        + $"Surname: {personTeacher.Surname} \n"
//        + $"BirthDate: {personTeacher.BirthDate.ToLongDateString()} \n"
//        + $"IsStudent: {personTeacher.IsStudent}"
//    );


// oop ye göre olması gereken

Person student = new Student
{
    Name = "Alparslan",
    Surname = "Akbaş",
    BirthDate = new DateTime(1999, 01, 03),
    IsStudent = true
};

Console.WriteLine($"-- Öğrenci Bilgileri --\n{student.GetInfo()}");

Console.WriteLine();

Person teacher = new Teacher
{
    Name = "Hasan Ali Veli",
    Surname = "Deli",
    BirthDate = new DateTime(1980, 01, 03),
    IsTeacher = true
};

Console.WriteLine($"-- Öğretmen Bilgileri --\n{teacher.GetInfo()}");