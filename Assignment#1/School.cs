using System;
using System.Collections.Generic;

namespace ASSIGNMENT1
{
    public class School
    {
        private List<Student> Students;
        private List<Teacher> Teachers;
        private List<Course> Courses;

        public School()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Courses = new List<Course>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddCourse(Course course, Teacher teacher)
        {
            course.Teacher = teacher;
            Courses.Add(course);
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine(student.GetStudentDetails());
            }
        }

        public void DisplayAllTeachers()
        {
            Console.WriteLine("Teachers:");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine(teacher.GetTeacherDetails());
            }
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("Courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine(course.GetCourseDetails());
            }
        }

        public string GetSchoolName()
        {
            return "Palestine School";
        }

        public int GetTotalTeachers()
        {
            return Teachers.Count;
        }
    }
}
