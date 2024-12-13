using System;
using System.Collections.Generic;

namespace ASSIGNMENT1
{
    public class Student
    {
        private static readonly string SCHOOL_NAME = "Palestine School";
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public DateTime AdmissionDate { get; }
        private List<Course> EnrolledCourses;

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            AdmissionDate = DateTime.Now;
            EnrolledCourses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            EnrolledCourses.Add(course);
        }

        public List<Course> GetEnrolledCourses()
        {
            return EnrolledCourses;
        }

        public string GetStudentDetails()
        {
            return $"Student ID: {Id}, Name: {Name}, Age: {Age}, Admission Date: {AdmissionDate.ToShortDateString()}, School: {SCHOOL_NAME}";
        }
    }
}
