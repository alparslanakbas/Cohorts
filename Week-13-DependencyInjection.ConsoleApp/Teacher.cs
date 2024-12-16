namespace Week_13_DependencyInjection.ConsoleApp
{
    internal class Teacher : ITeacher
    {
        public string FirstName { get; set; } = "Alparslan";
        public string LastName { get; set; } = "Akbas";

        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}
