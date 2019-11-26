using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Decorator
{
    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Filtered with care";
        }

        public double GetCost()
        {
            return 1.99;
        }
    }

    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso made with care";
        }

        public double GetCost()
        {
            return 2.99;
        }
    }

    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public abstract class AdditiveDecorator : ICoffee
    {
        ICoffee _coffee;

        protected string _name = "undefined condiment";
        protected double _price = 0.0;

        public AdditiveDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return string.Format("{0}, {1}", _coffee.GetDescription(), _name);
        }

        public double GetCost()
        {
            return _coffee.GetCost() + _price;
        }
    }

    public class MilkDecorator : AdditiveDecorator
    {
        public MilkDecorator(ICoffee coffee)
            : base(coffee)
        {
            _name = "Milk";
            _price = 0.19;
        }
    }

    public class ChocolateDecorator : AdditiveDecorator
    {
        public ChocolateDecorator(ICoffee coffee)
            : base(coffee)
        {
            _name = "Chocolate";
            _price = 0.29;
        }
    }

    public class CofeeHelper
    {
        public void ShouldSupportCondiments()
        {
            var beverages = new List<ICoffee>
            {
                new ChocolateDecorator(new Filtered()),
                new ChocolateDecorator(new MilkDecorator(new Espresso()))
            };
            
            var filteredWithChocolate = beverages.First();
            Console.WriteLine(filteredWithChocolate.GetDescription());
            Console.WriteLine(filteredWithChocolate.GetCost());

            var espressoWithMilkAndChocolate = beverages.Skip(1).First();
            Console.WriteLine(espressoWithMilkAndChocolate.GetDescription());
            Console.WriteLine(espressoWithMilkAndChocolate.GetCost());
        }
    }
}
