In C#, getters and setters are used in properties to provide controlled access to the private fields of a class. 
They are useful for encapsulation, allowing you to protect the internal state of an object while still exposing certain data or functionality to the outside world. Getters and setters give you fine control over how fields are read or written, and they can add logic or validation when accessing or modifying fields.

Purpose of Getters and Setters:

1.Encapsulation: Protect the internal data of a class by hiding the implementation details and exposing controlled access.

2.Data Validation: Implement logic to validate data before assigning it to a private field.

3.Flexibility: Allow you to modify the getter/setter implementation without changing the class's public interface.

4.Read-Only/Write-Only: You can control whether a property is read-only, write-only, or both by implementing either a getter, setter, or both.

5.Encapsulation: Protects the private fields and allows controlled access via getters and setters.

6.Validation: Allows you to add validation in the setter method.

7.Read-Only/Write-Only: You can control whether the property is read-only, write-only, or both.

8.Auto-Implemented Properties: Simplify code when no additional logic is required in the getter or setter.


Getters and setters provide a flexible and secure way to access and modify private fields in a class, enhancing encapsulation, validation, and control over how data is accessed or modified in an object.
