using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Design_Pattern.Iterator.Interface
{
    public class ConcreteIterator : Iterator
    {

        ConcreteAggregate aggregate;
        int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object CustomNext()
        {
            object tmp = null;
            if (current < aggregate.Count - 2)
            {
                tmp = aggregate[current += 2];
            }

            return tmp;

        }

        public override object First()
        {
            current = 0;
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public override object Next()
        {
            object tmp = null;
            if(current < aggregate.Count-1)
            {
                tmp = aggregate[++current];
            }

            return tmp;

        }
    }
}
