//class Student
//{
//    public int Id;
//    public string name;
//    public int age;
//    public string course;
//}
//class StudentManager
//{
//    List<Student> studentData = new List<Student>();
//    public void ViewStudent()
//    {
//        foreach (Student student in studentData)
//        {
//            Console.WriteLine($"the name is {student.name} his age is {student.age}");
//        }
//    }

//    public void AddStudent(Student student)
//    {
//        studentData.Add(student);

//    }
//    public void UpdateStudent(int id, Student updates)
//    {
//        var updated = studentData.FirstOrDefault(val => val.Id == id);
//        updated.Id = updated.Id;
//        updated.name = updates.name;
//        updated.age = updates.age;
//        updated.course = updates.course;
//    }

//    public void deleteStudent(int id)
//    {
//        var deletee = studentData.FirstOrDefault(val => val.Id == id);
//        studentData.Remove(deletee);

//    }
//    public List<Student> ageFilter(int age)
//    {
//        return studentData.Where(val => val.age > age).ToList();
//    }
//}
//class Course
//{
//    public int courseId { set; get; }
//    public string courseName { get; set; }

//}
//class CourseManager
//{
//    List<Course> CourseData = new List<Course>();
//    public void addCource(Course course)
//    {
//        CourseData.Add(course);
//    }
//    public void viewCourse()
//    {
//        foreach (Course course in CourseData)
//        {
//            Console.WriteLine($"the course of the id is {course.courseId} and the course name is {course.courseName}");
//        }
//    }
//    public IEnumerable<Course> courseFilter(string course)
//    {
//        return CourseData.Where(val => val.courseName == course);
//    }

//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        StudentManager sm = new StudentManager();
//        CourseManager cs = new CourseManager();
//        sm.AddStudent(new Student { Id = 1, name = "saleej", age = 22, course = "BBA" });
//        sm.AddStudent(new Student { Id = 2, name = "babi", age = 26, course = "maths" });
//        sm.AddStudent(new Student { Id = 3, name = "anas", age = 23, course = "BA eng" });
//        sm.AddStudent(new Student { Id = 4, name = "rayees", age = 22, course = "BBA" });
//        sm.ViewStudent();
//        sm.UpdateStudent(2, new Student { Id = 1, name = "jawad", age = 20, course = "LP" });
//        Console.WriteLine("\nStudents after Updating 2nd one");
//        sm.ViewStudent();
//        sm.deleteStudent(3);
//        Console.WriteLine("\nStudents after deleting 3nd one");
//        sm.ViewStudent();
//        //course
//        cs.addCource(new Course { courseId = 1, courseName = "science" });
//        cs.addCource(new Course { courseId = 2, courseName = "commerce" });
//        cs.addCource(new Course { courseId = 2, courseName = "commerce" });
//        cs.addCource(new Course { courseId = 3, courseName = "science" });
//        Console.WriteLine("\n \n \nCourse List");
//        cs.viewCourse();
//        Console.WriteLine("age above 22");
//        var ageFiltered = sm.ageFilter(21);
//        foreach (var age in ageFiltered) { Console.WriteLine($"name is {age.name} and age is {age.age}"); }
//        var courseFilter = cs.courseFilter("science");
//        foreach (var e in courseFilter)
//        {
//            Console.WriteLine($"student ID is {e.courseId} ,course is {e.courseName}");
//        }




//    }
//}

class Student { public int Id;
    public string name;
    public int age;
    public string course;
}
class Course
{
    public int courseId;
    public string courseName;
}
class StudentManager
{
    List<Student> students=new List<Student>();
    public void addStudent(Student studentDatas)
    {
        students.Add(studentDatas);
    }
    public void viewStudents()
    {
        foreach(Student i in students)
        {
            Console.WriteLine($"name is {i.name} age is {i.age}");
        }
    }
    public void updateStudent(int id,Student datas)
    {
        var newStudent = students.FirstOrDefault(val => val.Id == id);
        newStudent.Id = datas.Id;
        newStudent.name = datas.name;
        newStudent.age = datas.age;
        newStudent.course = datas.course;
    }
    public void deleteStudent(int id)
    {
        var deleteId=students.FirstOrDefault(val=>val.Id==id);
        students.Remove(deleteId);
    }
    //public List<Student> ageFilter()
    //{
    //    return students.Where(val=>val.age>20).ToList();
    //}
    public void ageFilter(int agee)
    {
        var c= students.Where(val => val.age > agee).ToList();
        foreach(Student student in c) { Console.WriteLine($"he is({student.name}) is now {student.age}"); };
    }
    public void courseFilter(string courseName)
    {
        var k= students.Where(val=>val.course==courseName).ToList();
        foreach(var i in k)
        {
            Console.WriteLine($"the student is {i.name} and his course is {i.course}");
        }
        
    }
}
class CourseManager
{
    List<Course> courseData = new List<Course>();
    public void addCourse(Course data)
    {
        courseData.Add(data);
    }
    public void viewCourse()
    {
        foreach (Course c in courseData) { Console.WriteLine($"the courSe is {c.courseName} and Id is {c.courseId}"); }
    }

}
class Program
{
    public static void Main(string[] args)
    {
        CourseManager cm = new CourseManager();
        StudentManager sm = new StudentManager();
        sm.addStudent(new Student() { Id = 1, name = "a", age = 23, course = "maths" });
        sm.addStudent(new Student() { Id = 2, name = "b", age = 21, course = "zology" });
        sm.addStudent(new Student() { Id = 3, name = "c", age = 22, course = "history" });
        sm.addStudent(new Student() { Id = 4, name = "d", age = 23, course = "zology" });
        sm.viewStudents();
        sm.updateStudent(3, new Student() { Id = 3, name = "babi", age = 24, course = "dotnet" }); Console.WriteLine("after editing a value");
        sm.viewStudents();
        cm.addCourse(new Course { courseId = 1, courseName = "science" });
        cm.addCourse(new Course { courseId = 2, courseName = "commerce" });
        cm.addCourse(new Course { courseId = 3, courseName = "commerce" });
        cm.addCourse(new Course { courseId = 4, courseName = "science" });
        cm.viewCourse();
        sm.ageFilter(23);
        sm.courseFilter("zology");
    } 
       
    }
