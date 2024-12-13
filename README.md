# School-Management-System



# School Management System

This project is a **School Management System** written in **C#**. It is designed to simulate the management of a school by modeling real-world entities such as **Students**, **Teachers**, and **Courses**. The system manages the relationships between these entities, such as enrollment, course assignments, and displaying relevant information.

---

## Project Structure

The project is composed of five classes:

- **`Program`** - The entry point of the application.
- **`Student`** - Represents a student in the school.
- **`Teacher`** - Represents a teacher in the school.
- **`Course`** - Represents a course offered by the school.
- **`School`** - Manages students, teachers, and courses at the school level.

---

## Detailed Explanation of Classes

### 1. `Student` Class
This class models a student in the school and includes properties, methods, and logic related to student activities.

**Properties**:
- `Id` (int): A unique identifier for the student.
- `Name` (string): The student's name.
- `Age` (int): The student's age.
- `AdmissionDate` (DateTime): The date when the student was admitted to the school.
- `EnrolledCourses` (List<Course>): A list of courses the student is enrolled in.

**Methods**:
- `EnrollInCourse(Course course)`: Allows the student to enroll in a course.
- `GetEnrolledCourses()`: Returns the list of enrolled courses.
- `GetStudentDetails()`: Provides a formatted string with student details.

---

### 2. `Teacher` Class
This class models a teacher and includes properties and methods for managing their responsibilities.

**Properties**:
- `Id` (int): A unique identifier for the teacher.
- `Name` (string): The teacher's name.
- `Age` (int): The teacher's age.
- `AdmissionDate` (DateTime): The date when the teacher was hired.
- `AssignedCourses` (List<Course>): A list of courses the teacher is responsible for.

**Methods**:
- `AssignCourse(Course course)`: Assigns a course to the teacher.
- `GetAssignedCourses()`: Returns the list of assigned courses.
- `GetTeacherDetails()`: Provides a formatted string with teacher details.

---

### 3. `Course` Class
This class represents a course offered by the school.

**Properties**:
- `Id` (int): A unique identifier for the course.
- `CourseName` (string): The name of the course.
- `Teacher` (Teacher): The teacher assigned to the course.

**Methods**:
- `GetCourseDetails()`: Returns a formatted string with course details.

---

### 4. `School` Class
This class acts as the main manager for all students, teachers, and courses in the school.

**Properties**:
- `Students` (List<Student>): A list of all students in the school.
- `Teachers` (List<Teacher>): A list of all teachers in the school.
- `Courses` (List<Course>): A list of all courses offered by the school.

**Methods**:
- `AddStudent(Student student)`: Adds a student to the school.
- `AddTeacher(Teacher teacher)`: Adds a teacher to the school.
- `AddCourse(Course course, Teacher teacher)`: Adds a course and assigns a teacher to it.
- `DisplayAllStudents()`: Prints details of all students.
- `DisplayAllTeachers()`: Prints details of all teachers.
- `DisplayAllCourses()`: Prints details of all courses.
- `GetSchoolName()`: Returns the name of the school.
- `GetTotalTeachers()`: Returns the total number of teachers.

---

### 5. `Program` Class
The `Program` class is the **entry point** of the application. It contains the `Main` method, where the program is executed.

**What It Does**:
1. Creates students (`Student` objects).
2. Creates teachers (`Teacher` objects).
3. Creates courses (`Course` objects).
4. Enrolls students in courses.
5. Assigns courses to teachers.
6. Adds students, teachers, and courses to the school (`School` object).
7. Displays information about the school, students, teachers, and courses using methods from the `School` class.

---

## Execution Workflow

1. **Students and Teachers Creation**:
   - Creates three students (`student1`, `student2`, `student3`) with their details.
   - Creates two teachers (`teacher1`, `teacher2`) with their details.

2. **Courses Creation**:
   - Creates two courses (`course1`, `course2`) and assigns teachers to them.

3. **Student Enrollment**:
   - Students are enrolled in courses:
     - `student1` and `student3` are enrolled in `course1`.
     - `student2` is enrolled in `course2`.

4. **Teacher Assignments**:
   - Teachers are assigned to their respective courses.

5. **School Management**:
   - All students, teachers, and courses are added to the `School` object.
   - Displays:
     - School name.
     - Total number of teachers.
     - List of all students, teachers, and courses.

---

## Sample Output

School Name: Palestine School Total Teachers: 2 Students: Student ID: 1, Name: Alice, Age: 16, Admission Date: 12/13/2024, School: Palestine School Student ID: 2, Name: Bob, Age: 17, Admission Date: 12/13/2024, School: Palestine School Student ID: 3, Name: Charlie, Age: 15, Admission Date: 12/13/2024, School: Palestine School Teachers: Teacher ID: 1, Name: Mr. Smith, Age: 35, Admission Date: 12/13/2024, School: Palestine School Teacher ID: 2, Name: Mrs. Johnson, Age: 40, Admission Date: 12/13/2024, School: Palestine School Courses: Course ID: 1, Name: Mathematics, Teacher: Mr. Smith Course ID: 2, Name: Physics, Teacher: Mrs. Johnson


---

## How to Run the Project

1. **Create a `.csproj` File**:
   Create a `Assignment1.csproj` file with the following content:

   ```xml
   <Project Sdk="Microsoft.NET.Sdk">
     <PropertyGroup>
       <OutputType>Exe</OutputType>
       <TargetFramework>net6.0</TargetFramework>
     </PropertyGroup>
   </Project>

dotnet restore
dotnet run
