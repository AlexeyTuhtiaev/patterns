using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface Irepository
    {
        void GetData(int id);
    }

    class TempClass : Irepository
    {
        public void GetData(int id)
        {
            int i = 0;
            i++;
        }
    }

    class TempWithCash : Irepository
    {
        private Dictionary<int, string> cache;
        public void GetData(int id)
        {
            if (cache != null && !cache.ContainsKey(id))
            {
                cache.Add(1, "1");
                return;
            }

            int i = 0;
            i++;
        }
    }

    public class CacheAdding : Irepository
    {
        private readonly Dictionary<int, string> cache;
        private readonly Irepository _repo;
        public CacheAdding(Irepository repo)
        {
            _repo = repo;
        }

        public void GetData(int id)
        {
            if (cache != null && !cache.ContainsKey(id))
            {
                cache.Add(1, "1");
                return;
            }

            _repo.GetData(id);
        }
    }

    public class WithCaching : CacheAdding
    {
        public WithCaching(Irepository repo) : base(repo)
        {

        }
    }

    public class MyUsing
    {
        public void MyMethod()
        {
            TempClass repo = new TempClass();
            WithCaching wc = new WithCaching(repo);
            wc.GetData(1);

        }
    }
}
