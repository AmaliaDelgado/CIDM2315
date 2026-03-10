using System.Security.Cryptography.X509Certificates;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor professor1 = new Professor();
        professor1.Name = "Alice";
        professor1.classTeach = "Java";
        professor1.SetSalary(9000);

        Professor professor2 = new Professor();
        professor2.Name = "Bob";
        professor2.classTeach = "Math";
        professor2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName = "Lisa";
        student1.classEnroll = "Java";
        student1.SetGrade(90);

        Student student2 = new Student();
        student2.studentName = "Tom";
        student2.classEnroll = "Math";
        student2.SetGrade(80);

        Console.WriteLine($"Professor {professor1.Name} teaches {professor1.classTeach}, and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"Professor {professor2.Name} teaches {professor2.classTeach}, and the salary is: {professor2.GetSalary()}");

        Console.WriteLine($"Student {student1.studentName} enrolls {student1.classEnroll}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.studentName} enrolls {student2.classEnroll}, and the grade is: {student2.GetGrade()}");

        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {totalGrade}");

    }
}

class Professor
{
    public string Name = string.Empty;
    public string classTeach = string.Empty;
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string studentName = string.Empty;
    public string classEnroll = string.Empty;
    private double grade;

    public void SetGrade(double grade_amount)
    {
        grade = grade_amount;
    }

    public double GetGrade()
    {
        return grade;
    }
}
