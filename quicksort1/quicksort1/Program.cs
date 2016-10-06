using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quicksort1
{
    class Program
    {
        static void Main(string[] args)
        {
            //快速排序算法
            //主函数定义初始化数组并且负责输出
            int[] array = { 24, 5, 68, 96, 214, 2, 78, 33, 62 };
            //调用排序函数
            Sort(array,0,array.Length-1);
            for(int i=0;i<array.Length;i++)
                Console.WriteLine(array[i]);
            Console.Read();
        }
        public static void Sort(int[] array, int left, int right)
        {
            int i, j, temp;
            if (left > right)
                return;
            i = left;
            j = right;
            temp = array[left];
            while (i != j)
            {
                while (array[j] >= temp && i < j)
                     j--;
                while (array[i] <= temp && i < j)
                     i++;             
                if (i < j)
                {
                    int t = array[i];
                    array[i] = array[j];
                    array[j] =t;
                }

            }
            array[left] = array[i];
            array[i] = temp;

            Sort(array, left, i - 1);
            Sort(array, i + 1, right);

        }
            
    }
}
