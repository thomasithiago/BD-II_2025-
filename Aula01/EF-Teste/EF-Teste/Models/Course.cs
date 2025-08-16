namespace EF_Teste.Models
{
    public class Course
    {
        public int ID    { get; set; }
        public string? name { get; set; }

        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
