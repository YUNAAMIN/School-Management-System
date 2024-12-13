# School-Management-System

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>School Management System</title>
</head>
<body>
    <h1>School Management System</h1>
    <p>
        This project is a <strong>School Management System</strong> written in <strong>C#</strong>. 
        It is designed to simulate the management of a school by modeling real-world entities such as 
        <strong>Students</strong>, <strong>Teachers</strong>, and <strong>Courses</strong>. 
        The system manages the relationships between these entities, such as enrollment, course assignments, 
        and displaying relevant information.
    </p>

    <h2>Project Structure</h2>
    <p>The project is composed of five classes:</p>
    <ul>
        <li><strong>Program</strong> - The entry point of the application.</li>
        <li><strong>Student</strong> - Represents a student in the school.</li>
        <li><strong>Teacher</strong> - Represents a teacher in the school.</li>
        <li><strong>Course</strong> - Represents a course offered by the school.</li>
        <li><strong>School</strong> - Manages students, teachers, and courses at the school level.</li>
    </ul>

    <h2>Detailed Explanation of Classes</h2>

    <h3>1. <code>Student</code> Class</h3>
    <p>This class models a student in the school and includes properties, methods, and logic related to student activities.</p>
    <ul>
        <li><strong>Properties:</strong>
            <ul>
                <li><code>Id</code> (int): A unique identifier for the student.</li>
                <li><code>Name</code> (string): The student's name.</li>
                <li><code>Age</code> (int): The student's age.</li>
                <li><code>AdmissionDate</code> (DateTime): The date when the student was admitted to the school.</li>
                <li><code>EnrolledCourses</code> (List<Course>): A list of courses the student is enrolled in.</li>
            </ul>
        </li>
        <li><strong>Methods:</strong>
            <ul>
                <li><code>EnrollInCourse(Course course)</code>: Allows the student to enroll in a course.</li>
                <li><code>GetEnrolledCourses()</code>: Returns the list of enrolled courses.</li>
                <li><code>GetStudentDetails()</code>: Provides a formatted string with student details.</li>
            </ul>
        </li>
    </ul>

    <h3>2. <code>Teacher</code> Class</h3>
    <p>This class models a teacher and includes properties and methods for managing their responsibilities.</p>
    <ul>
        <li><strong>Properties:</strong>
            <ul>
                <li><code>Id</code> (int): A unique identifier for the teacher.</li>
                <li><code>Name</code> (string): The teacher's name.</li>
                <li><code>Age</code> (int): The teacher's age.</li>
                <li><code>AdmissionDate</code> (DateTime): The date when the teacher was hired.</li>
                <li><code>AssignedCourses</code> (List<Course>): A list of courses the teacher is responsible for.</li>
            </ul>
        </li>
        <li><strong>Methods:</strong>
            <ul>
                <li><code>AssignCourse(Course course)</code>: Assigns a course to the teacher.</li>
                <li><code>GetAssignedCourses()</code>: Returns the list of assigned courses.</li>
                <li><code>GetTeacherDetails()</code>: Provides a formatted string with teacher details.</li>
            </ul>
        </li>
    </ul>

    <h3>3. <code>Course</code> Class</h3>
    <p>This class represents a course offered by the school.</p>
    <ul>
        <li><strong>Properties:</strong>
            <ul>
                <li><code>Id</code> (int): A unique identifier for the course.</li>
                <li><code>CourseName</code> (string): The name of the course.</li>
                <li><code>Teacher</code> (Teacher): The teacher assigned to the course.</li>
            </ul>
        </li>
        <li><strong>Methods:</strong>
            <ul>
                <li><code>GetCourseDetails()</code>: Returns a formatted string with course details.</li>
            </ul>
        </li>
    </ul>

    <h3>4. <code>School</code> Class</h3>
    <p>This class acts as the main manager for all students, teachers, and courses in the school.</p>
    <ul>
        <li><strong>Properties:</strong>
            <ul>
                <li><code>Students</code> (List<Student>): A list of all students in the school.</li>
                <li><code>Teachers</code> (List<Teacher>): A list of all teachers in the school.</li>
                <li><code>Courses</code> (List<Course>): A list of all courses offered by the school.</li>
            </ul>
        </li>
        <li><strong>Methods:</strong>
            <ul>
                <li><code>AddStudent(Student student)</code>: Adds a student to the school.</li>
                <li><code>AddTeacher(Teacher teacher)</code>: Adds a teacher to the school.</li>
                <li><code>AddCourse(Course course, Teacher teacher)</code>: Adds a course and assigns a teacher to it.</li>
                <li><code>DisplayAllStudents()</code>: Prints details of all students.</li>
                <li><code>DisplayAllTeachers()</code>: Prints details of all teachers.</li>
                <li><code>DisplayAllCourses()</code>: Prints details of all courses.</li>
                <li><code>GetSchoolName()</code>: Returns the name of the school.</li>
                <li><code>GetTotalTeachers()</code>: Returns the total number of teachers.</li>
            </ul>
        </li>
    </ul>

    <h3>5. <code>Program</code> Class</h3>
    <p>The <code>Program</code> class is the <strong>entry point</strong> of the application. It contains the <code>Main</code> method, where the program is executed.</p>
    <p>In this class, objects of <code>Student</code>, <code>Teacher</code>, <code>Course</code>, and <code>School</code> are created and their methods are called to simulate the school system's behavior.</p>

    <h2>Execution Workflow</h2>
    <ol>
        <li>Create students and teachers.</li>
        <li>Create courses and assign teachers to them.</li>
        <li>Enroll students in courses.</li>
        <li>Add all entities (students, teachers, courses) to the school.</li>
        <li>Display information about the school, students, teachers, and courses.</li>
    </ol>

    <h2>Sample Output</h2>
    <pre>
School Name: Palestine School
Total Teachers: 2
Students:
Student ID: 1, Name: Alice, Age: 16, Admission Date: 12/13/2024, School: Palestine School
...
    </pre>

    <h2>How to Run the Project</h2>
    <ol>
        <li><strong>Create a .csproj File:</strong>
            <pre>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>
</Project>
            </pre>
        </li>
        <li><strong>Restore Dependencies:</strong> Run <code>dotnet restore</code>.</li>
        <li><strong>Run the Program:</strong> Run <code>dotnet run</code>.</li>
    </ol>
</body>
</html>
