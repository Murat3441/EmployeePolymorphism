// Define an interface called IQuittable
public interface IQuittable
{
    // Declare a method called Quit() with no return type (void)
    void Quit();
}

// Create an Employee class
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }

    // Implement the Quit() method inherited from IQuittable
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit!");
        Console.ReadLine();
    }
}

// Demonstrate polymorphism using IQuittable
public class Program
{
    public static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee { FirstName = "John", LastName = "Doe", ID = 1234 };

        // Create an IQuittable object and assign the Employee object to it
        // This is possible because Employee implements IQuittable
        IQuittable quitter = employee;

        // Call the Quit() method on the IQuittable object
        // Polymorphism ensures that the Employee class's Quit() method is called
        quitter.Quit();
    }
}
