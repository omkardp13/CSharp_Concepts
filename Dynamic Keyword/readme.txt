The following code snippet declares a dynamic field, a dynamic property, a dynamic method and a dynamic variable.

// Define a dynamic field.
dynamic name;

// Define a dynamic property.
dynamic NameProperty { get; set; }

// Define a dynamic method with a dynamic parameter type.
public dynamic FullNameMethod(dynamic d)
{
    name = "Mahesh";
    dynamic firstname = name;
    string lastname = "Chand";
    return firstname + lastname;
}
C#
As you may have noticed from the code above, a dynamic variable can store any type of value. A method can also return a dynamic type and also can accept dynamic parameters.

Here is an example with a dynamic variable that can store a string, an integer, a double, and a Boolean value.

dynamic dyno = "Mahesh Chand";
Console.WriteLine(dyno);
dyno = 38;
Console.WriteLine(dyno);
dyno = 44.95;
Console.WriteLine(dyno);
dyno = true;
Console.WriteLine(dyno);
C#
Dynamic types can also be converted explicitly to other types and vice versa. The following code snippet converts a string, an integer, and a double type into dynamic types by casting them with the dynamic keyword.

dynamic d;
string name = "Mahesh Chand";
d = (dynamic)name;
Console.WriteLine(d);

int age = 38;
d = (dynamic)age;
Console.WriteLine(d);

double price = 44.95d;
d = (dynamic)price;
Console.WriteLine(d);
C#
Dynamic can be used with classes too. The following example defines an Author class with a dynamic method FullNameMethod. The Main method creates a dynamic type of the Author class and calls its dynamic method by passing a dynamic parameter.

namespace DynamicProgSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic lastName = "Chand";
            dynamic dynAuthor = new Author();
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));

            Console.ReadKey();
        }
    }

    public class Author
    {
        // Define a dynamic field.
        dynamic name;

        // Define a dynamic property.
        dynamic NameProperty { get; set; }

        // Define a dynamic method with a dynamic parameter type.
        public dynamic FullNameMethod(dynamic d)
        {
            name = "Mahesh";
            dynamic firstname = name;
            return firstname + " " + d;
        }
    }
}

