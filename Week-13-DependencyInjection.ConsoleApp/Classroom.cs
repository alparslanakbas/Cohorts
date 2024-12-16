namespace Week_13_DependencyInjection.ConsoleApp
{
    internal class Classroom
    {
        public Classroom(Teacher teacher)
        {
            Teacher = teacher;
        }

        public Teacher Teacher { get; set; }

        public void GetTeacherInfo()
        {
            Teacher.GetInfo();
        }
    }
}
