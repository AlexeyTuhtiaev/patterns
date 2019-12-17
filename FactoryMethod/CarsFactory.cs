using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class CarsFactory
    {
        private string name;
        public CarsFactory(string name)
        {
            this.name = name;
        }

        public abstract Car CreateCar();
    }

    public abstract class Car { }

    class FerraryFactory : CarsFactory
    {
        public FerraryFactory(string name) : base(name)
        {

        }
        public override Car CreateCar()
        {
            return new Ferrary();
        }
    }

    class Ferrary : Car
    {
        public Ferrary()
        {
            Console.WriteLine("Ferrary was produced");
        }
    }

    class LamborginyFactory : CarsFactory
    {
        public LamborginyFactory(string name) : base(name)
        {

        }
        public override Car CreateCar()
        {
            return new Lamborginy();
        }
    }

    class Lamborginy : Car
    {
        public Lamborginy()
        {
            Console.WriteLine("Lamborginy was produced");
        }
    }
}

