using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Design_Pattern.Iterator
{


    class Item
    {
        private String name;
        private int cost;


        public Item(String name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public override string ToString()
        {
            return "(" + name + ", " + cost + " )";
        }
    }
}
