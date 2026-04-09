using Homework_LINQ_20260409;

Student[] students = new Student[]
{
    new Student() { StID = 1, FirstName = "John", LastName = "Smith", Age = 22},
    new Student() { StID = 2, FirstName = "Sam", LastName = "Johnson", Age = 20 },
    new Student() { StID = 3, FirstName = "Andrew", LastName = "Williams", Age = 20},
    new Student() { StID = 4, FirstName = "Phil", LastName = "Brown", Age = 19},
    new Student() { StID = 5, FirstName = "Jack", LastName = "Jones", Age = 23 }
};

CourseStudent[] StudentsInCourses = new CourseStudent[]
{
        new CourseStudent() { CourseName = "Math", StID = 1 },
        new CourseStudent() { CourseName = "Science", StID = 2 },
        new CourseStudent() { CourseName = "History", StID = 3 },
        new CourseStudent() { CourseName = "Math", StID = 4 },
        new CourseStudent() { CourseName = "Science", StID = 5 }
};

//Query syntax
var query = from s in students
            join c in StudentsInCourses on s.StID equals c.StID
            where c.CourseName == "Science" && s.Age > 19
            select s;

//Method syntax
//var query = students.Join(StudentsInCourses, s => s.StID, c => c.StID, (s, c) => new {s.LastName, c.CourseName})
//    .Where(c => c.CourseName == "History")
//    .Select(x => x.LastName);

foreach (var q in query)
{
    Console.WriteLine($"Student taking History: {q.FirstName} {q.LastName} ");
}