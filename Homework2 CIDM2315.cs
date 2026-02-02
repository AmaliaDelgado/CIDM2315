namespace Homework2CIDM2315;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        char grade;

        Console.WriteLine("Please input a letter grade:");
        grade = Convert.ToChar(Console.ReadLine());

        if (grade == 'A' || grade == 'a')
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade == 'B' || grade == 'b')
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade == 'C' || grade == 'c')
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade == 'D' || grade == 'd')
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade == 'F' || grade == 'f')
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        //Code for Q2
        Console.WriteLine("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }
        Console.WriteLine("The smallest number is: " + smallest);

        //Code for Bonus question
    }
}
