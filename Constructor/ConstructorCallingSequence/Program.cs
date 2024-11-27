using System;

class Program
{
   
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor of A");
        }
    }
    public class B:A
    {
        public B() //Calls the constructor A
        {
            Console.WriteLine("Constructor of B");
        }
    }
    public class C:B
    {
        public C()
        {
            Console.WriteLine("Constructor of C");
        }
    }

    static void Main()
    {
        C obj = new C();
        Console.ReadLine();  //OP: Constructor of A
                             //       Constructor of B
                             //     Constructor of C
    }
}
