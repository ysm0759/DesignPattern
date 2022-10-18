using System.Collections.Generic;

namespace Design_Pattern.Iterator.Interface
{
    public class ConcreteAggregate : Aggregate
    {

        List<object> items = new List<object>();




        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);   
        }



        public int Count
        {
            get { return items.Count; }
        }

        
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}