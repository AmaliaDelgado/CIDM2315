namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6); 
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (gradebook.ContainsKey("Tom")==false)
        {
            gradebook.Add("Tom", 3.3);
        }

        double total = 0;

        foreach (var gpa in gradebook.Values)
        {
            total += gpa;
        }
        double average = total / gradebook.Count;
        Console.WriteLine($"The average GPA is: {average:F2}");

        foreach (Student stu in Student.student_list)
        {
            if (gradebook[stu.stuName] > average)
            {
                stu.PrintInfo();
            }
        }
    }
}

class Student
{
    public static List<Student> student_list = new List<Student>();
    private int studentID;
    private string studentName;

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public Student (int inputID, string inputName)
    {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
    public int stuID
    {
        get { return studentID; }
    }
    public string stuName
    {
        get { return studentName; }
    }
}
