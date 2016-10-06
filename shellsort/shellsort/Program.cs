using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shellsort
{
    class Program
    {
        static void Main(string[] args)
        {
            //希尔排序，插入排序的特殊情况，加强版
            int[] sortnumbers = { 2, 1, 6, 87, 45, 25, 61, 99, 37, 6, 111, 4 };
            int i = 0;
            int gap = sortnumbers.Length / 2;
            while (gap > 0) {
                for (i = gap; i < sortnumbers.Length; i++) {
                    int temp = sortnumbers[i];
                    int j = i - gap;
                    while (j >= 0 && sortnumbers[j] > temp) {
                        sortnumbers[j + gap] = sortnumbers[j];
                        j -= gap;
                    }
                    sortnumbers[j + gap] = temp;
                }
                gap /= 2;
            }
            for (i = 0; i < sortnumbers.Length; i++) {
                Console.WriteLine(sortnumbers[i]);
            }
            Console.Read();
        }
    }
}
