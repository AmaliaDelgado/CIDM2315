namespace Homework4CIDM2315;

class Program
{

    static int GetLargest (int a, int b)
    {
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main()
    {
        int a = 3;
        int b = 5;

         int largest = GetLargest(a, b);
        Console.WriteLine("a ="+ a + "b =" + b );
        Console.WriteLine("The largest number is:"+ largest);
        PrintShape(5, "left");
        PrintShape (5, "right");
    }
   
   static void PrintShape (int N, string shape)  {   
       Console.WriteLine ($"N is: {N}; shape is {shape}");

       if (shape == "left") 
       {
           for (int i = 1; i <= N; i++)
        {
            Console.WriteLine (new string ('*', i));
        }
       }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string (' ', N-i) + new string('*', i));
            }
        }
       
   }

}
