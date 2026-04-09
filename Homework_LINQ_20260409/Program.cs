using Homework_LINQ_20260409;

Student[] students = new Student[]
{
    new Student() { StID = 1, LastName = "Smith" },
    new Student() { StID = 2, LastName = "Johnson" },
    new Student() { StID = 3, LastName = "Williams" },
    new Student() { StID = 4, LastName = "Brown" },
    new Student() { StID = 5, LastName = "Jones" }
};

CourseStudent[] StudentsInCourses = new CourseStudent[]
{
        new CourseStudent() { CourseName = "Math", StID = 1 },
        new CourseStudent() { CourseName = "Science", StID = 2 },
        new CourseStudent() { CourseName = "History", StID = 3 },
        new CourseStudent() { CourseName = "Math", StID = 4 },
        new CourseStudent() { CourseName = "Science", StID = 5 }
};

var query = from s in students
            join c in StudentsInCourses on s.StID equals c.StID
            where c.CourseName == "History"
            select s.LastName;

foreach(var q in query)
{
    Console.WriteLine($"Student taking History: {q}");
}