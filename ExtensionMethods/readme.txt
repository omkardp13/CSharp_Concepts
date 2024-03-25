Extension Methods: Extension methods allows you to add new methods to existing types without modifying them.
---------------------------------------Interview Questions------------------------------------------------------------------------------------------------------------------
1.What are extension methods in C#?
Answer: Extension methods enable you to add new methods to existing types without modifying, deriving, or recompiling the original type. They are static methods but are called as if they were instance methods of the extended type.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.How do you define an extension method in C#?
Answer: To define an extension method, you need to create a static class and define a static method within that class. The first parameter of the method specifies the type that the method extends, and the parameter is preceded by the this modifier. Here's an example:

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3.How do you call an extension method?
Answer: Extension methods are called using instance method syntax. This means that you call them as if they were instance methods of the extended type. Here's how you would call the Reverse extension method defined above:

string original = "hello";
string reversed = original.Reverse();

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4.Can extension methods access private members of the extended type?

Answer: No, extension methods cannot access private members of the extended type. They can only access public members of the type.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5.How do you ensure that extension methods are available in your code?
Answer: To use extension methods, you need to ensure that the namespace containing the extension methods is in scope. You can achieve this by either importing the namespace with a using directive or by fully qualifying the extension method.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6.Can you extend sealed classes with extension methods?

Answer: Yes, you can extend sealed classes with extension methods. However, you cannot add instance members to sealed classes directly.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
7.Can extension methods be overridden or hidden in derived classes?

Answer: No, extension methods cannot be overridden or hidden in derived classes. They are resolved statically based on the compile-time type of the object.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
8.What are some common use cases for extension methods?

Answer: Common use cases for extension methods include:
Adding utility methods to built-in types or third-party types.
Enhancing readability and maintainability by grouping related functionality.
Implementing fluent interfaces to improve code readability.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
9.How do extension methods differ from regular static methods?

Answer: Extension methods provide a way to add new methods to existing types without modifying those types. They are called as if they were instance methods of the extended type, which can improve code readability and maintainability. Static methods, on the other hand, are defined within a class and called directly using the class name.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
10.Can extension methods be used to modify the behavior of value types (structs)?

Answer: Yes, extension methods can be applied to both reference types (classes) and value types (structs). However, it's important to note that extension methods cannot modify the value of the struct itself, as structs are immutable by default. Instead, they operate on copies of the struct.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
11.Can extension methods be used to add instance members to a type?

Answer: No, extension methods cannot add instance members to a type. They can only add static methods that appear to be instance methods when called.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------12.How do extension methods behave when there is an existing method with the same signature?

Answer: Extension methods will not be invoked if there is an existing method with the same signature on the extended type. In such cases, the existing method takes precedence over the extension method.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
13.Can extension methods access this parameter directly?

Answer: No, extension methods cannot access the this parameter directly. The this parameter is used to specify the type being extended, and it acts as the instance on which the method is invoked. However, within the method body, you can treat the this parameter as an instance of the extended type.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
14.What are some limitations of extension methods?
Answer: Some limitations of extension methods include:
They cannot access private or protected members of the extended type.
They cannot be used to override or hide existing methods.
They cannot be used to add instance members to a type.
They must be in a top-level static class.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
15.Can extension methods be used to extend interfaces?
Answer: No, extension methods cannot extend interfaces directly. Extension methods can only extend classes or structs. However, extension methods defined for a type can be invoked when an instance of that type is accessed through an interface reference.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
16.What is the difference between extension methods and inheritance?

Answer: Extension methods allow you to add functionality to existing types without modifying them or inheriting from them. Inheritance, on the other hand, involves creating a new type that inherits the members of an existing type and can override or extend those members.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
17.Can extension methods be used with asynchronous methods?
Answer: Yes, extension methods can be used with asynchronous methods. You can define extension methods that return Task or Task<T> and use them in asynchronous code just like regular methods.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
18.How do you handle null values in extension methods?
Answer: It's important to handle null values gracefully in extension methods, especially when accessing properties or methods of the extended type. You can do this by adding null checks before accessing members of the extended object, or by using the null-conditional operator (?.) introduced in C# 6.0.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
19.Can extension methods be used to add constructors to a type?
Answer: No, extension methods cannot be used to add constructors to a type. Constructors are not methods and cannot be defined as extension methods. Extension methods can only add static methods to a type.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
20.How do extension methods contribute to code readability and maintainability?
Answer: Extension methods can improve code readability and maintainability by allowing you to logically group related functionality and keep it separate from the core implementation. They also allow you to extend types without modifying them directly, which can make the codebase more modular and easier to understand.
