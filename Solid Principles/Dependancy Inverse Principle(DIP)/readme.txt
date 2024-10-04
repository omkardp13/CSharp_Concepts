Dependancy Inverse Principle(DIP) ---> the high level modules (such as classes or component's reprenting major functionalities) should not directly depends on low level modules(such as specific implementation of those functionality) insted,both high level and low-level modules should depend on the abstraction (interfaces or abstract classes).This promotes loose coupling between modules,making the system more flexible & easier to maintain.

This design allow's for flexibility & easy substitution of diffrent types of light bulb's without modifying the 'lightswitch' class 

----------------------------------------------------------------------------------------------------------------------------------------------

Here’s another example of the Dependency Inversion Principle (DIP) in C# using a logger system where different logging mechanisms (e.g., FileLogger, DatabaseLogger) can be easily swapped.

1.Without Dependency Inversion:

// Low-level module
public class FileLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

// High-level module
public class UserService
{
    private FileLogger _fileLogger;

    public UserService()
    {
        _fileLogger = new FileLogger(); // tightly coupled to FileLogger
    }

    public void RegisterUser(string username)
    {
        // User registration logic
        _fileLogger.Log($"User {username} registered.");
    }
}

public class Program
{
    public static void Main()
    {
        var userService = new UserService();
        userService.RegisterUser("JohnDoe");
    }
}

----------------------------------------------------------------------------------------------------------------------------------------------
2.With Dependency Inversion (DIP applied):

// Abstraction (interface)
public interface ILogger
{
    void Log(string message);
}

// Low-level module 1
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

// Low-level module 2
public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to database: {message}");
    }
}

// High-level module depends on abstraction
public class UserService
{
    private readonly ILogger _logger;

    // Dependency is injected via constructor
    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void RegisterUser(string username)
    {
        // User registration logic
        _logger.Log($"User {username} registered.");
    }
}

public class Program
{
    public static void Main()
    {
        // Switch between different loggers easily
        ILogger logger = new DatabaseLogger();
        var userService = new UserService(logger);
        userService.RegisterUser("JohnDoe");
    }
}

---------------------------------------------------------------------------------------------------------------------------------------
Key Points:

Before DIP: The UserService class is tightly coupled with FileLogger, making it difficult to switch to another logging mechanism like DatabaseLogger without modifying the UserService class.

After DIP: By depending on an abstraction (ILogger), the UserService class can work with any logger implementation, whether it's FileLogger, DatabaseLogger, or any future logging mechanism without changing its internal logic.

Another Example - Database Repositories:
Let’s look at an example where a repository pattern is used, and how DIP can help make the database access more flexible.

Without Dependency Inversion:
csharp
Copy code
// Low-level module
public class SqlProductRepository
{
    public List<string> GetProducts()
    {
        // SQL logic to get products from a database
        return new List<string> { "Laptop", "Phone", "Tablet" };
    }
}

// High-level module
public class ProductService
{
    private SqlProductRepository _productRepository;

    public ProductService()
    {
        _productRepository = new SqlProductRepository(); // tightly coupled to SQL
    }

    public void ListProducts()
    {
        var products = _productRepository.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

public class Program
{
    public static void Main()
    {
        var productService = new ProductService();
        productService.ListProducts();
    }
}
With Dependency Inversion (DIP applied):
csharp
Copy code
// Abstraction (interface)
public interface IProductRepository
{
    List<string> GetProducts();
}

// Low-level module 1
public class SqlProductRepository : IProductRepository
{
    public List<string> GetProducts()
    {
        // SQL logic to get products
        return new List<string> { "Laptop", "Phone", "Tablet" };
    }
}

// Low-level module 2
public class InMemoryProductRepository : IProductRepository
{
    public List<string> GetProducts()
    {
        // In-memory products
        return new List<string> { "Book", "Pen", "Notebook" };
    }
}

// High-level module depends on abstraction
public class ProductService
{
    private readonly IProductRepository _productRepository;

    // Dependency is injected via constructor
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void ListProducts()
    {
        var products = _productRepository.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Switch repositories easily
        IProductRepository productRepository = new InMemoryProductRepository();
        var productService = new ProductService(productRepository);
        productService.ListProducts();
    }
}

----------------------------------------------------------------------------------------------------------------------------------------------
Key Points:

Before DIP: The ProductService was tied to SqlProductRepository, making it difficult to switch to a different data source.

After DIP: By depending on the IProductRepository interface, ProductService can work with any repository implementation, whether it is a SQL database, in-memory data, or even a future API-based repository.

These examples illustrate how DIP allows high-level modules to remain flexible by depending on abstractions (interfaces) rather than concrete implementations, promoting better scalability and easier maintainability.
