//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Design_Pattern.Iterator
//{
//    class List : Aggregator
//    {
//        private Node node;


//        public Iterator Iterator()
//        {
//            return new ListIterator(this);

//        }


//        public Item GetItem(int index)
//        {
//            return items[index];
//        }

//        public int GetCount()
//        {
//            return items.Length;
//        }

//    }

//    class Node
//    {
//        Node preNode;
//        Node nextNode;
//        Item item;

//        public Node()
//        {
//            preNode = null;
//            nextNode = null;
//            this.item = null;
//        }
//    }


//}
