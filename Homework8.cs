namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
//Customer objects and customer_list
 Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
 Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
 Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
 Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
 Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
 Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	 Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};


 // call Q1 method
 TotalCredits(customer_list);
 // call Q2 method
 AmarilloAverageAge(customer_list);
 // call Q3 method
 CanyonAge(customer_list);
    }
// Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list){
        {
            double totalCredit = 0;
            foreach (Customer customer in customer_list)
            {
                totalCredit += customer.CustomerCredit;
            }
            Console.WriteLine($"The total credits: {totalCredit}");
        }
}


// Q2 Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list){
        {
            int totalAge = 0;
            int count = 0;
            foreach (Customer customer in customer_list)
            {
                if (customer.CustomerCity == "Amarillo")
                {
                    totalAge += customer.CustomerAge;
                    count++;
                }
            }
            double averageAge = totalAge / (double)count;
            Console.WriteLine($"The average age of customers in Amarillo: {averageAge}");
        }
}


// Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list){
        {
            Console.Write("Customers who live in Canyon and over 30 years old: ");
            bool first = true;
            foreach (Customer customer in customer_list)
            {
                if (customer.CustomerCity == "Canyon" && customer.CustomerAge > 30)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    Console.Write($"{customer.CustomerName}");
                    first = false;
                }
            }
            Console.WriteLine();
        }
}
}
// Q0: Create a class called Customer
class Customer{
    public string CustomerName { get; set; } = string.Empty;
    public int CustomerAge { get; set; } = 0;
    public string CustomerCity { get; set; } = string.Empty;
    public double CustomerCredit { get; set; } = 0.0;
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.CustomerName = customerName;
        this.CustomerAge = customerAge;
        this.CustomerCity = customerCity;
        this.CustomerCredit = customerCredit;

    }
}
