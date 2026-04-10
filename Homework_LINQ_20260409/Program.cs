using Homework_LINQ_20260409;

Student[] students = new Student[]
{
    new Student() { StID = 1, FirstName = "John", LastName = "Smith", Age = 22},
    new Student() { StID = 2, FirstName = "Anna", LastName = "Lewis", Age = 20 },
    new Student() { StID = 3, FirstName = "Andrew", LastName = "Williams", Age = 20},
    new Student() { StID = 4, FirstName = "Phil", LastName = "Brown", Age = 19},
    new Student() { StID = 5, FirstName = "Jack", LastName = "Matuidi", Age = 23 },
    new Student() { StID = 6, FirstName = "Mark", LastName = "Johanson", Age = 18 },
    new Student() { StID = 7, FirstName = "Steve", LastName = "Arnold", Age = 24 },
    new Student() { StID = 8, FirstName = "Jack", LastName = "Grilsih", Age = 22 },
    new Student() { StID = 9, FirstName = "Sandra", LastName = "Parker", Age = 20 }
};

CourseStudent[] StudentsInCourses = new CourseStudent[]
{
    new CourseStudent() { CourseName = "Math", StID = 1 },
    new CourseStudent() { CourseName = "Science", StID = 2 },
    new CourseStudent() { CourseName = "History", StID = 3 },
    new CourseStudent() { CourseName = "Math", StID = 4 },
    new CourseStudent() { CourseName = "Science", StID = 5 },
    new CourseStudent() { CourseName = "Math", StID = 6 },
    new CourseStudent() { CourseName = "Math", StID = 7 },
    new CourseStudent() { CourseName = "Science", StID = 8 },
    new CourseStudent() { CourseName = "Science", StID = 9 }

};

//1. Query syntax
var query1 = (from s in students
            join c in StudentsInCourses on s.StID equals c.StID
            where c.CourseName == "Science" && s.Age > 19
            select s).Take(3);

//2. Method syntax
var query2 = students.Join(StudentsInCourses, s => s.StID, c => c.StID, (s, c) => new { s.FirstName, s.LastName, c.CourseName })
    .Where(c => c.CourseName == "Science")
    .Select(x => x).Take(3);

foreach (var q in query1)
{
    Console.WriteLine($"Student taking History: {q.FirstName} {q.LastName} ");
}

Console.WriteLine("---");

foreach (var q in query2)
{
    Console.WriteLine($"Student taking History: {q.FirstName} {q.LastName} ");
}