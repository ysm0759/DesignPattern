using Design_Pattern.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Strategy
{
    class StrategyMain
    {
        public static void Main(string[] args)
        {
            Context context = new Context();


            context.InitData();


            context.SetSortStrategy(new Insertion());
            context.Sort();
            
            context.SetSortStrategy(new Bubble());
            context.Sort();

            context.SetSortStrategy(new Merge());
            context.Sort();


        }
    }
}
