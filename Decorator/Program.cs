using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            concreteComponent.Operation();

            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            decoratorA.SetComponent(concreteComponent);
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
            decoratorB.SetComponent(concreteComponent);

            decoratorA.Operation();
            decoratorB.Operation();


            Console.WriteLine("-----------------------------");

            Repo repo = new Repo();
            repo.GetId();

            DecoratorForIRepo decoratorForIRepo = new DecoratorForIRepo(repo);

            decoratorForIRepo.GetId();

            Console.WriteLine("-----------------------------");

            new CofeeHelper().ShouldSupportCondiments();
        }
    }
}
