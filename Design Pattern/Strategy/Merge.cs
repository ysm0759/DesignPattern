using Design_Pattern.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Strategy
{
    public class Merge : SortStrategy
    {
        int[] tmpArray;
        public override object Sort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작

            tmpArray = new int[array.Length];
            Array.Copy(array, tmpArray, array.Length);



            MergeSort(array, 0, array.Length - 1);


            stopwatch.Stop();
            System.Console.WriteLine("Merge time : " +
                               stopwatch.ElapsedMilliseconds + "ms");

            print(tmpArray);

            return null;
        }


        void MergeSort(int[] array, int left, int right)
        {
            int mid;
            if (left < right)
            {
                mid = (left + right) / 2; 
                MergeSort(array, left, mid); 
                MergeSort(array, mid + 1, right); 
                merge(array, left, mid, right);
            }
        }

        void merge(int[] array, int left, int mid, int right)
        {
            int i, j, k, l;
            i = left;
            j = mid + 1;
            k = left;

            /* 분할 정렬된 list의 합병 */
            while (i <= mid && j <= right)
            {
                if (array[i] <= array[j])
                    tmpArray[k++] = array[i++];
                else
                    tmpArray[k++] = array[j++];
            }

            // 남아 있는 값들을 일괄 복사
            if (i > mid)
            {
                for (l = j; l <= right; l++)
                    tmpArray[k++] = array[l];
            }
            // 남아 있는 값들을 일괄 복사
            else
            {
                for (l = i; l <= mid; l++)
                    tmpArray[k++] = array[l];
            }

            // 배열 sorted[](임시 배열)의 리스트를 배열 list[]로 재복사
            for (l = left; l <= right; l++)
            {
                array[l] = tmpArray[l];
            }
        }

    }
}
