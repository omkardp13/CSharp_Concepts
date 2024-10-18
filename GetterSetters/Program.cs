using System;

class Product
{
    // Private fields
    private string name;
    private double price;
    private int stock;

    // 1. Encapsulation: Property for Name with getter and setter
    public string Name
    {
        get { return name; }  // Getter
        set { name = value; } // Setter
    }

    // 2. Data Validation: Property for Price with validation in the setter
    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value; // Valid price
            else
                throw new ArgumentException("Price must be positive.");
        }
    }

    // 3. Flexibility: Property for Stock with a getter and setter that can later be modified
    public int Stock
    {
        get { return stock; }
        set
        {
            if (value >= 0)
                stock = value; // Valid stock value
            else
                throw new ArgumentException("Stock cannot be negative.");
        }
    }

    // 4. Read-Only Property: Only getter, no setter
    public bool IsInStock
    {
        get { return stock > 0; }  // Read-only, returns true if stock > 0
    }

    // 5. Write-Only Property: Only setter, no getter (for demonstration)
    private string internalCode;
    public string InternalCode
    {
        set { internalCode = value; }  // Write-only, can set but not read
    }

    // Constructor to initialize product
    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new product
        Product product = new Product("Laptop", 1200.99, 50);

        // 1. Encapsulation: Access the product's name using property
        Console.WriteLine($"Product Name: {product.Name}");

        // 2. Data Validation: Attempting to set an invalid price throws an error
        try
        {
            product.Price = -500;  // Invalid price, throws exception
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);  // Output: Price must be positive.
        }

        // 3. Flexibility: Changing stock, and validation happens in the setter
        product.Stock = 30;
        Console.WriteLine($"Product Stock: {product.Stock}");

        // 4. Read-Only: IsInStock checks stock but cannot be set directly
        Console.WriteLine($"Is in Stock: {product.IsInStock}");

        // 5. Write-Only: You can set InternalCode but cannot read it
        product.InternalCode = "ABC123";  // Set write-only property
        // Can't access it, e.g., Console.WriteLine(product.InternalCode); // This would cause a compile error

        // Changing price to valid
        product.Price = 1300.50;
        Console.WriteLine($"Updated Price: {product.Price}");
    }
}
