using System;
using System.Collections.Generic;

namespace ASSIGNMENT1
{
    public class Teacher
    {
        private static readonly string SCHOOL_NAME = "Palestine School";
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public DateTime AdmissionDate { get; }
        private List<Course> AssignedCourses;

        public Teacher(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            AdmissionDate = DateTime.Now;
            AssignedCourses = new List<Course>();
        }

        public void AssignCourse(Course course)
        {
            AssignedCourses.Add(course);
        }

        public List<Course> GetAssignedCourses()
        {
            return AssignedCourses;
        }

        public string GetTeacherDetails()
        {
            return $"Teacher ID: {Id}, Name: {Name}, Age: {Age}, Admission Date: {AdmissionDate.ToShortDateString()}, School: {SCHOOL_NAME}";
        }
    }
}
