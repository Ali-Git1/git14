using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 250, 23, 457, 456, 321, 875, 246, 190, 234, 800, 9837, 12351 };

            Console.Write("1 ci reqemi daxil edin");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 ci reqemi daxil edin");
            int b1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {

                int sum = 0;
                if (array[i] > a1 && array[i] < b1)
                {
                    Console.WriteLine(array[i]);
                    while (array[i] > 0)
                    {
                        sum += (array[i] % 10);
                        array[i] = array[i] / 10;

                    }

                }
                if (sum > 7)
                {
                    Console.Write($"Ededin reqem cemi" + array[i]);

                }









                //}

                //foreach (var item in array)
                //{
                //    int sum = 0;
                //    if(item>a1&& item<b1)
                //    {
                //        int temp = item;
                //        while(temp>0) 
                //        { 
                //            int last=temp%10;
                //              sum+=last;
                //Temp /= 10;

                //        }

                //    }
                //}

            }
        }
        
    }
}
