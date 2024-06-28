// See https://aka.ms/new-console-template for more information
using Assignment3;
using Assignment3.DataModel;

//Console.WriteLine("Hello, World!");


// Working with Methods 

// 1. 

ReverseArray rA = new ReverseArray();
int[] numbers = rA.GenerateNumbers(10);
rA.PrintNumbers(numbers);
Console.WriteLine();    
rA.Reverse(numbers);
rA.PrintNumbers(numbers);


// 2. 

FibonacciProb fb = new FibonacciProb();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(fb.Fibonacci(i));
}
Console.WriteLine();    



// OOPS 
// Abstraction, Encapsulation, Inheritance and Polymorphism 
// 1-6
//Abs - diff class stu, instru for person type
// Encap - details private in class
// Inherit -- extend person type 
// Poly - virtual methods - derive class to override - like salary cals
// Interfaces - ICourseService, IStudentService, IInstructorService, IDepartmentService, IPersonService --- Person specific methods
// -- IStudentService, IInstructorService - inherit from IPersonService
//Person - cal age, cal sal, Mul address
//student - mul courses, cal GPA, course Grade A to F 
//Copurse- list of enroll students 
// dept - one instru as head, Budget for school year , Offer list of courses 

Student student = new Student
{
    Name = "ajay",
    BirthDate = new DateTime(2002, 1, 1)
};


Instructor instructor = new Instructor
{
    Name = "Dr. lax",
    BirthDate = new DateTime(1965, 9, 9),
    Salary = 70000,
    JoinDate = new DateTime(2000, 1, 1)
};


Department itDepartment = new Department
{
    DepartmentName = "Information Technology",
    Budget = 200000,
    BudgetStart = new DateTime(2024, 1, 1),
    BudgetEnd = new DateTime(2024, 12, 30),
    Head = instructor
};


Course course1 = new Course { CourseName = "Programming in IT" };
Course course2 = new Course { CourseName = "Data mining" };


itDepartment.AddCourse(course1);
itDepartment.AddCourse(course2);


student.EnrollInCourse(course1);
student.EnrollInCourse(course2);


Console.WriteLine($"Student: {student.Name}, Age: {student.CalculateAge()}");
Console.WriteLine($"Instructor: {instructor.Name}, Age: {instructor.CalculateAge()}, Salary: {instructor.CalculateBonus()}");
Console.WriteLine($"Department: {itDepartment.DepartmentName}, Head: {itDepartment.Head.Name}");


Console.WriteLine($"Courses enrolled by {student.Name}:");
foreach (var course in student.GetCourses())
{
    Console.WriteLine(course.CourseName);
}






// 7. Color balls

Color red = new Color(255, 0, 0);
Color green = new Color(0, 255, 0);
Color blue = new Color(0, 0, 255);


Ball redb = new Ball(10, red);
Ball greenb = new Ball(15, green);
Ball blueb = new Ball(20, blue);


redb.Throw();
greenb.Throw();
blueb.Throw();
redb.Throw();
blueb.Throw();
greenb.Throw();

redb.Pop(); 
blueb.Pop();    
greenb.Pop();
redb.Throw();
blueb.Throw();
greenb.Throw();

Console.WriteLine($"Red ball throw count: {redb.GetThrowCount()}");
Console.WriteLine($"Green ball throw count: {greenb.GetThrowCount()}");
Console.WriteLine($"Blue ball throw count: {blueb.GetThrowCount()}");









