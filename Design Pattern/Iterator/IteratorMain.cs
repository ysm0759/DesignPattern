using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator.Interface
{
    class IteratorMain
    {
        public static void Main(string[] args)
        {
            ConcreteAggregate numbers = new ConcreteAggregate();
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 20;


            ConcreteAggregate characters = new ConcreteAggregate();
            characters[0] = "Wairror";
            characters[1] = "archer";
            characters[2] = "magician";
            characters[3] = "healer";
            characters[4] = "farmer";
            characters[5] = "engineer";
            characters[6] = "student";
            characters[7] = "NPC";
            characters[8] = "teacher";




            Console.WriteLine("Iterator using next data");

            Iterator iter = numbers.CreateIterator();
            object item = iter.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iter.Next();
            }


            Console.WriteLine("\nIterator use other data");

            iter = characters.CreateIterator();
            item = iter.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iter.Next();
            }

            Console.WriteLine("\nIterator Use Custom Next");

            iter = characters.CreateIterator();
            item = iter.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iter.CustomNext();
            }


        }
    }
}
