internal record Student(int Id, string Name, int ClassId);
internal record Class(int Id, string Name);


// recordslar c# 9 ile geldi. recordslar immutabledır yani değerleri değiştirilemez. kullanım amacı veri taşıma ve veri tutma işlemlerinde kullanılır.
// ben çoğunlukla net core projelerimde dto nesnelerimde record kullanıyorum. model classlar ayrı onlar db contextlerde kullanılıyor.
class Program
{
    static void Main()
    {
        IReadOnlyList<Class> classes = new List<Class>
       {
           new Class(1, "Matematik"),
           new Class(2, "Türkçe"),
           new Class(3, "Kimya"),
       };

        IReadOnlyList<Student> students = new List<Student>
       {
            new Student(1, "Ali", 1),
            new Student(2, "Ayşe", 1),
            new Student(3, "Mehmet", 2),
            new Student(4, "Fatma", 2),
            new Student(5, "Ahmet", 3),
            new Student(6, "Alparslan", 3),
       };

        var result = classes.GroupJoin(students, c => c.Id, s => s.ClassId, (c, s) => new { Class = c, Students = s });

        foreach (var item in result)
        {
            Console.WriteLine($"Sınıf adı: {item.Class.Name}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($"Öğrenci Adı: {student.Name}");
            }
            Console.WriteLine();
        }
    }
}