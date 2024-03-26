the liskov substitution principle(LSP) states that object of superclass should be replaced by object of it's subclasses without affecting the correctness of the program.
It means that derived classes should behave in a way that consistent with the behaviour expected from base class,ensuring that you can frely substitute object of subclasses whenever the base class is used without breaking the program's functionality.


in this abouve example both 'car' & 'bicycle' inherit from the 'vehicle' class.According LSP,any method that works with instances of 'vehicle' class should also work with instances of it's derived classes('car' & 'bicycle') without causing error and unexpected behaviour.

When we  call 'MoveAll()' with an array containing both car & bicycle's object it correctly move all vehicles,whether they are car's or bicycle's.This demonstrate that object of subclass ('car' & 'bicycle') can be substituted for object's of their subclass('vehicle') without affecting the correctness of the program.
