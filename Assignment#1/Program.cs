using System;

namespace ASSIGNMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(1, "Alice", 16);
            var student2 = new Student(2, "Bob", 17);
            var student3 = new Student(3, "Charlie", 15);

            var teacher1 = new Teacher(1, "Mr. Smith", 35);
            var teacher2 = new Teacher(2, "Mrs. Johnson", 40);

            var course1 = new Course(1, "Mathematics", teacher1);
            var course2 = new Course(2, "Physics", teacher2);

            student1.EnrollInCourse(course1);
            student2.EnrollInCourse(course2);
            student3.EnrollInCourse(course1);

            teacher1.AssignCourse(course1);
            teacher2.AssignCourse(course2);

            var school = new School();
            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);
            school.AddTeacher(teacher1);
            school.AddTeacher(teacher2);
            school.AddCourse(course1, teacher1);
            school.AddCourse(course2, teacher2);

            Console.WriteLine($"School Name: {school.GetSchoolName()}");
            Console.WriteLine($"Total Teachers: {school.GetTotalTeachers()}");

            school.DisplayAllStudents();
            school.DisplayAllTeachers();
            school.DisplayAllCourses();
        }
    }
}
