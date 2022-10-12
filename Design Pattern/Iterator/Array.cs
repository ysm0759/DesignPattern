using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator
{
    class Array : Aggregator
    {
        private Item[] items;
        public Array(Item[] items)
        {
            this.items = items;
        }

        public Item GetItem(int index)
        {
            return items[index];
        }

        public int GetCount()
        {
            return items.Length;
        }


        public Iterator Iterator()
        {
            return new ArrayIterator(this);
        }

    }
}
