namespace Homework7CIDM2315;
class Customer
{
    private int customer_id;
    public string customer_name;
    public int customer_age;
    
    //Constructor
    public Customer(int customer_id, string name, int age)
    {
        this.customer_id = customer_id;
        this.customer_name = name;
        this.customer_age = age;
    }

    //change ID
    public void ChangeID(int new_id)
    {
        this.customer_id = new_id;
    }

    //print customer info
    public void printCustomerInfo()
    {
        Console.WriteLine($"Customer: {customer_id}, name: {customer_name}, age: {customer_age}");
    }

    //compare age
    public void CompareAge(Customer newCustomer)
    {
        if (this.customer_age > newCustomer.customer_age)
        {
            Console.WriteLine($"{this.customer_name} is older");
        }
        else
        {
            Console.WriteLine($"{newCustomer.customer_name} is older");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer (110, "Alice", 28);
        Customer customer2 = new Customer (111, "Bob", 30);
        
        customer1.printCustomerInfo();
        customer2.printCustomerInfo();

        customer1.ChangeID(220);
        customer2.ChangeID(221);
        customer1.printCustomerInfo();
        customer2.printCustomerInfo();

        customer1.CompareAge(customer2);
    }
}
