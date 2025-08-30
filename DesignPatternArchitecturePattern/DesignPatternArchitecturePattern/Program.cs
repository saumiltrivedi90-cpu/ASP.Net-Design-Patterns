using DesignPatternArchitecturePattern;

class Program
{
    static void Main(string[] args)
    {
        //Polimorphism in action
        ICustomer customer = new NormalCustomer();
        customer.Name = "John Doe";
        customer.Age = "30";
        customer.Amount = 1000M;
        decimal discount = customer.CalculateDiscount();
    }
}