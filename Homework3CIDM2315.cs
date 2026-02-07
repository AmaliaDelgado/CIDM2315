using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace homework3CIDM2315;

class Program
{
    static void Main(string[] args)
    {
        //code for question 1
        Console.Write("input an integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (num1 <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num1); i++)
            {
                if (num1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{num1} is prime");
        }
        else
        {
            Console.WriteLine($"{num1} is non-prime");
        }
       
       
       
        //code for question 2
        Console.Write("Assign an int value to N: ");
        int num2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < num2; i++)
        {
            for (int j = 0; j < num2; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
     
        
        
        //code for question 3
        
        Console.Write("Assign an int value to N: ");
        int num3 = int.Parse(Console.ReadLine());
        for (int row = 1; row <= num3; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col <= row)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
  
