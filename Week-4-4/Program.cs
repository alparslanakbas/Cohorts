using Week_4_4;

Student student = new()
{
    Id = Guid.NewGuid(),
    FirstName = "Alparslan",
    Surname = "Akbaş",
    StudentIdentifyNumber = Guid.NewGuid()
};

Teacher teacher = new()
{
    Id = Guid.NewGuid(),
    FirstName = "Alparslan",
    Surname = "Akbaş",
    Salary = 85000.00f
};

student.WriteToConsoleForStudent();
teacher.WriteToConsoleForTeacher();