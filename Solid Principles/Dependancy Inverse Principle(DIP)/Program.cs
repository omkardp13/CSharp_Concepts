using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal  class Program
    {
     
       //Abstraction:ILightBulb interface

        interface ILightBulb
        {
            void Toggle();
        }
        //High level model:Light Switch

        class LightSwitch
        {
            private ILightBulb bulb;

            //Constructor injecting abstraction
            public LightSwitch(ILightBulb bulb)
            {
                this.bulb = bulb;
            }

            public void Toggle() 
            {
                this.bulb.Toggle();
            }

        }

        //low-level models implementing the abstraction
        //Icandescend bulb

        class IcandescenBulb : ILightBulb
        {
            public void Toggle()
            {
                Console.WriteLine("IcandescenBulb toggle");
            }
        }
        //LEDBulb class

        class LEDBulb : ILightBulb
        {
            public void Toggle()
            {
                Console.WriteLine("LED bulb toggle");

            }
        }


        static void Main(string[] args)
        {
            //using dependacy injection to inject specific light bulb
            LightSwitch icande=new LightSwitch(new IcandescenBulb());
            LightSwitch ledSwitch=new LightSwitch(new LEDBulb());

            icande.Toggle();
            ledSwitch.Toggle();
            Console.Read();
        }
    }
}
