using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface ICarSet
    {
        string GetCarCharacteristic();
        double GetCost();
    }

    public class BaseCar : ICarSet
    {
        public string GetCarCharacteristic()
        {
            return "airbag, heated seats";
        }

        public double GetCost()
        {
            return 10000;
        }
    }

    public class CarDecorator : ICarSet
    {
        protected readonly ICarSet _baseCar;
        protected string _additionalCharacteristic;
        protected int _additionalCost;

        public CarDecorator(ICarSet baceCar)
        {
            _baseCar = baceCar;
        }

        public string GetCarCharacteristic()
        {
            return String.Format("{0}, {1}", _baseCar.GetCarCharacteristic(), _additionalCharacteristic);
        }

        public double GetCost()
        {
            return _baseCar.GetCost() + _additionalCost;
        }
    }

    public class AutomaticTransmissionSet : CarDecorator
    {
        public AutomaticTransmissionSet(ICarSet baceCar) : base(baceCar)
        {
            _additionalCharacteristic = "Automatic Transmission";
            _additionalCost = 1500;
        }
    }
}
