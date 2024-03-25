Factory Pattern:Provides an interface for creating instances of class,but allows subclasses to alter the type of objects that will be created.It defines an interface for creating an object ,but lets subclasses alter the type of objects that will be created on run-time. 

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                          **Interview Questions**
1.What is the Factory Design Pattern?
Ans:The Factory Design Pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. It defines an interface for creating objects but defers the instantiation to subclasses.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.What problem does the Factory Design Pattern solve?
Ans:The Factory Design Pattern solves the problem of creating objects without specifying the exact class of object that will be created or how it will be created. It promotes loose coupling by abstracting the process of object creation.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3.What are the key components of the Factory Design Pattern?
Ans:The key components include:
Factory Interface or Class: Defines a method for creating objects.
Concrete Factories: Implement the factory method to create objects.
Products: The objects created by the factory.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4.Can you explain the difference between a Simple Factory and a Factory Method?
Ans:In a Simple Factory, a single factory method is used to create objects, while in a Factory Method pattern, the responsibility of creating objects is delegated to subclasses, each of which provides its own implementation of the factory method.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5.Can you give an example of where you would use the Factory Design Pattern in a real-world scenario?
Ans:One example could be a software application for a pizza restaurant. The application might have a PizzaFactory interface with methods for creating different types of pizzas (e.g., Margherita, Pepperoni). Concrete pizza factories would implement this interface to create specific types of pizzas.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6.How does the Factory Design Pattern promote loose coupling?
Ans:The Factory Design Pattern promotes loose coupling by allowing the client code to interact with the factory interface rather than directly with the concrete classes that are instantiated. This means that the client code is not dependent on specific implementations of the products, which can be changed or extended without modifying the client code.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
7.What are the advantages of using the Factory Design Pattern?
Ans:The advantages include:
Promotes loose coupling between client code and created objects.
Encapsulates object creation logic, making it easier to modify and extend.
Centralizes object creation, which can simplify complex object creation processes.
Allows for easy switching between different implementations of objects without affecting client code.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
8.How does the Factory Design Pattern relate to dependency injection?
Ans:Dependency injection is a design pattern where objects are passed their dependencies rather than creating them internally. Factories can be used to implement dependency injection by encapsulating the creation of objects and passing them to dependent classes. This helps in achieving loose coupling and improves testability.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
9.What are some potential drawbacks or limitations of the Factory Design Pattern?
Ans:Some drawbacks include:
Increased complexity, especially if there are many different types of objects to be created.
Possible violation of the Open/Closed Principle if new types of objects need to be added frequently, requiring modification of existing factory classes.
Overuse can lead to unnecessary abstraction and complexity in the codebase. It's essential to apply the pattern judiciously where it adds value.
