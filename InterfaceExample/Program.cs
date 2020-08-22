using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new Duck();
            var plane = new Airplane();
            var helicopter = new Helicopter();

            //you can build a collection of all the things that implement the IFlyable interface:
            var flyingThings = new List<IFlyable> { duck, plane, helicopter };

            foreach(var thing in flyingThings)
            {
                //pattern matching: check if this thing we are on is using the ITakeOff interface and if yes, put it in the takeOff variable and then let me use it:
                if (thing is ITakeOff takeOff)
                {
                    takeOff.TakeOff("Bahamas");
                }
                thing.Fly();
            }
        }
    }
}
