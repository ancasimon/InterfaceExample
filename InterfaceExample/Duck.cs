using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Duck: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Quack, I'm a flying duck.");
        }
    }

    class Airplane: IFlyable, ITakeOff
    {
        public void TakeOff(string destination)
            {
            Console.WriteLine($"We're taking off on a plane towards {destination}!");
        }
        public void Fly()
        {
            Console.WriteLine("We're flying on a plane!");
        }
    }

    class Helicopter : IFlyable, ITakeOff
    {
        public void TakeOff(string destination)
        {
            Console.WriteLine($"We're taking off on a helicopter for {destination}!");
        }
        public void Fly()
        {
            Console.WriteLine("Hovering in a helicopter.");
        }
    }

    interface IFlyable
    {
        void Fly();
    }

    interface ITakeOff
    {
        void TakeOff(string destination);
    }

}
