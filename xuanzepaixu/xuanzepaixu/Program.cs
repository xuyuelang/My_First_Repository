using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xuanzepaixu
{
    class Program
    {
        static void Main(string[] args)
        {
            //选择排序
            //定义并初始化一个数组
            int[] sortnumbers = { 2,5,8,65,23,96,105,24 };
            int i = 0;
            //for循环 定位到每一个元素
            for (i = 0; i < sortnumbers.Length-1; i++) { 
                int min=i;
                //for循环，与第一个循环元素相比找出最小的
                for (int j = i+1; j < sortnumbers.Length; j++) {
                    if (sortnumbers[j] < sortnumbers[min])
                        min = j;
                }
                int temp = sortnumbers[min];
                sortnumbers[min] = sortnumbers[i];
                sortnumbers[i]=temp; 
                //for循环输出数组
                 
            }
            for (i = 0; i < sortnumbers.Length; i++)
            { Console.Write("{0,5}", sortnumbers[i]); }
            Console.Read();
           
        }
    }
}
