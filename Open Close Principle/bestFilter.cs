using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, secound;
        public AndSpecification(ISpecification<T> f, ISpecification<T> s) {
            first = f;
            secound = s;
        }

        public bool IsSatisfaied(Phone p)
        {
            return first.IsSatisfaied(p) && secound.IsSatisfaied(p);
        }
    }

    public class bestFilter : IFilter<Phone>
    {
        public IEnumerable<Phone> Filter(IEnumerable<Phone> items, ISpecification<Phone> spec){
            foreach (var i in items) {
                if (spec.IsSatisfaied(i)) {
                    yield return i;
                }
            }
        }
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
    public interface ISpecification<T>
    {
        bool IsSatisfaied(Phone p);
    }
    public class brandSpecification : ISpecification<Phone>
    {
        private Brand myBrand;
        public brandSpecification(Brand b)
        {
            this.myBrand = b;
        }
        public bool IsSatisfaied(Phone p)
        {
            return p.brand == myBrand;
        }
    }
    public class processorSpecification : ISpecification<Phone>
    {
        private Processor myProcessor;
        public processorSpecification(Processor p)
        {
            myProcessor = p;
        }
        public bool IsSatisfaied(Phone p)
        {
            return p.proc == myProcessor;
        }
    }
}
