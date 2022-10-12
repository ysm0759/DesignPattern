using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator
{
    class IteratorMain
    {
        static void Main(string[] args)
        {
            Item[] items =
            {
                new Item("CPU",1000),
                new Item("Keyboard", 2000),
                new Item("Mouse", 3000),
                new Item("HDD", 50),
            };

            Array array = new Array(items);
            Iterator iter = array.Iterator();
            Console.WriteLine(array.GetItem(1));
            while(iter.Next())
            {
                Item item = (Item)iter.Current();
                Console.WriteLine(item.ToString());
            }

        }
    }
}
