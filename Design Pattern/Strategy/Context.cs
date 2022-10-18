using Design_Pattern.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Strategy
{
    public class Context
    {
        int[] array = new int[100];
        Random random = new Random();

        SortStrategy sortStrategy;


        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void InitData()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
        }

        public void Sort()
        {
            print();
            sortStrategy.Sort(array);
        }

        public void print()
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
