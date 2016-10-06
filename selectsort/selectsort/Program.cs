using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace selectsort
{
    class Program
    {
        static void Main(string[] args)
        {
            //选择排序
            //定义并初始化要排序的元素数组
            int[] sortnumbers = { 2, 5, 9, 11, 65, 37, 28, 96, 55 };
            int i = 0;
            //for循环，找参考元素
            for (i = 0; i < sortnumbers.Length-1; i++) {
                int min=i;
                //for循环，依次与参考元素比较大小，找出最小的放到最前边
                for (int j = i + 1; j < sortnumbers.Length; j++) {
                    if (sortnumbers[j] < sortnumbers[min])
                        min = j;
                }  
                //交换元素
                int temp = sortnumbers[min];
                sortnumbers[min] = sortnumbers[i];
                sortnumbers[i] = temp;
            }
                
             //for循环输出排好的元素
            for (i = 0; i < sortnumbers.Length; i++) {
                Console.Write( "{0,7}",sortnumbers[i]);
            }
            Console.Read();
           
        }
    }
}
