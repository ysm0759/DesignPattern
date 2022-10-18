using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Design_Pattern.Strategy.Interface;

namespace Design_Pattern.Strategy
{
    public class Bubble : SortStrategy
    {
        int[] tmpArray;
        public override object Sort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작
            tmpArray = new int[array.Length];

            Array.Copy(array, tmpArray, array.Length);
           // tmpArray = array;
            int tmp;


            for(int i =0; i < tmpArray.Length;i++)
            {

                for(int j =0; j < tmpArray.Length - i -1; j++)
                {
                    if(tmpArray[j] > tmpArray[j+1])
                    {
                        tmp = tmpArray[j+1];
                        tmpArray[j+1] = tmpArray[j];
                        tmpArray[j] = tmp;
                    }
                }
            }


            stopwatch.Stop(); 
            System.Console.WriteLine("Bubble time : " +
                               stopwatch.ElapsedMilliseconds + "ms");

            print(tmpArray);
            return null;
        }


    }


}
