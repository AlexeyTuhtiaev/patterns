using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();

            CarsFactory ferraryFactory = new FerraryFactory("FerraryFactory");
            ferraryFactory.CreateCar();

            CarsFactory lamborginyFactory = new LamborginyFactory("LamborginyFactory");
            lamborginyFactory.CreateCar();

            Console.ReadLine();
        }
    }    
}
