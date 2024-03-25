**-------------Singleton Pattern------------**
1.Class has only one instance and provides global point to this instance.
2.This pattern is usefull when exactly one object is needed across the system.
Charactoristics:
1.Private Constructor:Prevent other classes from creating instance of it,
2.Private Instance:Class contains private,static instance itself.
3.Static Access Method:Allows other classes to access single instance.



**------------------------------------------------------Interview Questions------------------------------------------**
1.What is the Singleton Design Pattern?

Answer: The Singleton Design Pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.Can you explain the motivation behind using the Singleton pattern?
Answer: The Singleton pattern is used when exactly one object is needed to coordinate actions across the system. For example, a logger, configuration manager, or database connection pool are good candidates for Singleton since they should not have multiple instances.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3.How do you implement a Singleton class in C#?
Answer: There are different ways to implement a Singleton in C#, but the most common one involves creating a private constructor, a static property to access the instance, and a static method to create or retrieve the instance. Here's a basic example:

public class Singleton
{
    private static readonly Singleton instance = new Singleton();

    private Singleton() { }

    public static Singleton Instance => instance;
}
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

4.How do you ensure thread safety in a Singleton implementation?
Answer: Thread safety in Singleton can be ensured using various techniques:
Using a lock statement or Mutex for synchronization.
Using the Lazy<T> type in .NET, which ensures thread safety by default.
In C# 6.0 and later, using the Lazy<T> type simplifies lazy initialization while ensuring thread safety.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5.What are the potential drawbacks of the Singleton pattern?
Answer: Some potential drawbacks include:
Global state: Since Singletons provide global access to their instance, they can introduce tightly coupled dependencies and hidden dependencies.
Testing: Singletons can make unit testing difficult due to their global state. Mocking Singletons can also be challenging.
Multithreading issues: Implementing a thread-safe Singleton can be complex and may introduce performance overhead due to synchronization mechanisms.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6.Can you discuss scenarios where the Singleton pattern is useful?
Answer: The Singleton pattern is useful in scenarios where there should be exactly one instance of a class, such as:
Managing resources shared by the entire application (e.g., configuration settings, logging).
Implementing caching mechanisms.
Controlling access to limited resources (e.g., database connections, thread pools).

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
7.How does the Singleton pattern differ from a static class?

Answer: While both ensure that there's only one instance, Singletons are classes that can implement interfaces, inherit from base classes, and be passed around as parameters. On the other hand, static classes cannot be instantiated, inherited, or passed as parameters. They are primarily used for providing utility methods or holding shared state.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
8.How can you ensure that a Singleton is serializable in C#?

Answer: To ensure that a Singleton is serializable in C#, you need to mark the Singleton class with the [Serializable] attribute and implement custom serialization logic. One common approach is to mark the Instance property as non-serialized and provide custom logic to handle deserialization.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
9.How do you handle scenarios where a Singleton needs to be lazily initialized and also thread-safe?

Answer: You can use the Lazy<T> type available in .NET to achieve lazy initialization and thread safety simultaneously. The Lazy<T> type ensures that the Singleton instance is created lazily and in a thread-safe manner without the need for explicit synchronization.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
10.Can you implement a Singleton using dependency injection (DI)?

Answer: While it's generally not recommended to use DI with Singletons (as it goes against the idea of having a single global instance), you can create a Singleton instance outside the DI container and register it as a singleton within the container. However, be cautious about introducing tight coupling and potential issues with testing and scalability.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
11.How does the Singleton pattern apply in a multithreaded environment?

Answer: In a multithreaded environment, special attention must be given to ensure that the Singleton instance is thread-safe. Techniques such as lazy initialization with double-check locking, using the Lazy<T> type, or relying on static initialization are commonly used to ensure thread safety.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
12.What are some alternatives to the Singleton pattern?

Answer: Some alternatives to the Singleton pattern include:
Dependency injection: Allow dependencies to be injected into classes rather than relying on global state.
Service locator pattern: Similar to DI but with a centralized registry of services.
Factory pattern: Use factories to create instances of classes instead of relying on a single global instance.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
13.What are some common misconceptions about the Singleton pattern?

Answer: Some common misconceptions include:
Assuming that Singletons are always the best solution for managing global state.
Overusing Singletons, leading to tight coupling and hidden dependencies.
Believing that Singletons are automatically thread-safe; proper synchronization is still required in multithreaded environments.
