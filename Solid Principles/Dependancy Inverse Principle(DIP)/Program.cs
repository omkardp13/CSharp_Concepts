using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
          Interfaces: ILightBulb
          The ILightBulb interface defines the contract for a light bulb. 
          It contains a single method Toggle(), which means any class that implements this interface must provide a definition for this method. 
     */
    interface ILightBulb
    {
        void Toggle();
    }

    /*
     * This class represents a light switch that controls a light bulb. 
     * It has a private field _lightBulb of type ILightBulb, which means it expects any class that implements ILightBulb.

      Constructor:
       The constructor of LightSwitch takes an ILightBulb object as an argument, demonstrating Dependency Injection. 
       The light switch doesn't create the bulb itself; rather, it expects a bulb to be passed to it, allowing for flexibility.
     */
    class LightSwitch
    {
        private ILightBulb _lightBulb;

        public LightSwitch(ILightBulb bulb)
        {
            this._lightBulb = bulb;
        }

        public void Toggle() 
        {
            _lightBulb.Toggle();
        }
    }

    class HalogenBulb : ILightBulb
    {
        public void Toggle()
        {
            Console.WriteLine("HalogenBulb toggle");
        }
    }

    class LEDBulb : ILightBulb
    {
        public void Toggle()
        {
            Console.WriteLine("LED Bulb toggle");
        }
    }

    internal class Program
    {
        /*
         * In the Main method, two instances of the LightSwitch class are created:

         Halogen Light Switch: A LightSwitch is created with a HalogenBulb object passed to it.
         LED Light Switch: Another LightSwitch is created with an LEDBulb object passed to it.
         Both switches are then toggled, resulting in the Toggle() methods of the respective bulbs being called, and the corresponding messages are printed to the console.
         */
        static void Main(string[] args)
        {
            LightSwitch halogen = new LightSwitch(new HalogenBulb());

            LightSwitch led = new LightSwitch(new LEDBulb());

            halogen.Toggle();
            led.Toggle();
            Console.ReadKey();
        }
    }

    /*
     * Interface (ILightBulb): Defines a common contract for different bulb types (e.g., halogen, LED). Both HalogenBulb and LEDBulb must implement the Toggle() method.

       Dependency Injection: The LightSwitch class doesn't know or care about the specific type of bulb it controls. It only depends on the interface ILightBulb. This allows you to easily change the type of bulb by passing different implementations of ILightBulb.

       Polymorphism: When you pass an instance of HalogenBulb or LEDBulb to the LightSwitch constructor, the LightSwitch interacts with them via the ILightBulb interface, demonstrating polymorphism.
     * 
     */
}
