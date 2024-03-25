Open/Closed Principle (OCP): this principle states that s/w entities (such as classes,modules,functions etc) should be open for extension but closed for modification.
In simple terms ,you should be able to extend the behaviour of module without modifying it's source code this can achived through inheritance,composition and abstraction.


In the abouve example the shape class is open for extension as you can create new shapes by extending it(e.g adding a tringle class).howver it closed for modification,as you don't need to modify the existing shape classes to add new shapes
