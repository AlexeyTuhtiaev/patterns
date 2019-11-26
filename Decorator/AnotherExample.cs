using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    interface IRepo
    {
        void GetId();
    }

    class Repo : IRepo
    {
        public void GetId()
        {
            Console.WriteLine("Repo");
        }
    }

    class DecoratorForIRepo
    {
        protected readonly IRepo _repo;
        public DecoratorForIRepo(IRepo repo)
        {
            _repo = repo;
        }

        public void GetId()
        {
            Console.WriteLine("DecoratorForIRepo");
            _repo.GetId();
        }
    }
}
