using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Strategy.Interface
{
    public class Insertion : SortStrategy
    {
        int[] tmpArray;
        public override object Sort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작

            tmpArray = new int[array.Length];

            Array.Copy(array, tmpArray, array.Length);
            int tmp;

            for (int i = 0; i < tmpArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (tmpArray[j - 1] > tmpArray[j])
                    {
                        tmp = tmpArray[j - 1];
                        tmpArray[j - 1] = tmpArray[j];
                        tmpArray[j] = tmp;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            stopwatch.Stop();
            System.Console.WriteLine("Insertion time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            print(tmpArray);

            return null;
        }
    }
}
