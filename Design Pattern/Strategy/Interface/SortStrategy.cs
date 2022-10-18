using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Strategy.Interface
{
    public abstract class SortStrategy
    {
        public abstract object Sort(int[] array);

        public void print(int[] array)
        {
            Console.Write(" -------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" - ");
            }
            Console.WriteLine();
            Console.Write(" -------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }

    }
}
