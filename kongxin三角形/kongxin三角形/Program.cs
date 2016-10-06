using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kongxin三角形
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
             
            n =int.Parse( Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                if (i < n)
                    for (j = 1; j < 2 * n; j++)
                    {
                        if (j == n + 1 - i || j == n + i - 1) 
                            Console.Write("*");
                        else 
                            Console.Write(" ");
                    }

                else
                {
                    for (j = 1; j <= 2 * n-n; j++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
