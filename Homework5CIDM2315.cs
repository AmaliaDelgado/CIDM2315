using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;
using System.Transactions;

namespace Homework5CIDM;

class Program
{
    static void Main(string[] args)
    {
    //Q1    
    int a = GetInteger();
    int b = GetInteger();
    int largest = GetLargest(a, b);
    Console.WriteLine($"a={a}, b={b}");
    Console.WriteLine($"The largest number is: {largest}");
    
    //Q2
    int num1 = GetInteger();
    int num2 = GetInteger();
    int num3 = GetInteger();
    int num4 = GetInteger();

    int max = GetLargest(num1, num2);
    max = GetLargest(max, num3);
    max = GetLargest(max, num4);

    Console.WriteLine($"a={num1}, b={num2}, c={num3}, d={num4}");
    Console.WriteLine($"The largest number is: {max}");
    
    //Q3
    CreateAccount();

    }
        static int GetInteger()
        {
            string input = Console.ReadLine();
            int value = Convert.ToInt16(input);
            return value;
        }
    static int GetLargest (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static bool CheckAge (int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void CreateAccount()
        {
            Console.WriteLine("Enter Your Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Your Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Your Password Again:");
            string confirm_password = Console.ReadLine();
            Console.WriteLine("Enter Your Birthyear:");
            int BirthYear = Convert.ToInt16(Console.ReadLine());

            if (CheckAge(BirthYear))
            {
                if (password == confirm_password)
                {
                    Console.WriteLine("Account created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
        
}

