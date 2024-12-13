namespace ASSIGNMENT1
{
    public class Course
    {
        public int Id { get; }
        public string CourseName { get; }
        public Teacher Teacher { get; set; }

        public Course(int id, string courseName, Teacher teacher)
        {
            Id = id;
            CourseName = courseName;
            Teacher = teacher;
        }

        public string GetCourseDetails()
        {
            return $"Course ID: {Id}, Name: {CourseName}, Teacher: {Teacher.Name}";
        }
    }
}
