using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator
{
    class ArrayIterator : Iterator
    {


        private Array array;
        private int index;

        public ArrayIterator(Array array)
        {
            this.array = array;
            this.index = -1;
        }
        public object Current()
        {
            return array.GetItem(index);
        }

        public bool Next()
        {
            index++;
            return index < array.GetCount();
        }
    }
}
