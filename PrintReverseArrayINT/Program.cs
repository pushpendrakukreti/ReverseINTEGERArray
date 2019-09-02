using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReverseArrayINT
{
    class Program
    {
        static int reverseArray(int[] arr,int len)
        {
            int i;
            for (i = 0; i < len; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
            return 0;
        }
        static void Main(string[] args)
        {
            int i,n;
            Console.Write("Enter Size of Array = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSize of array is "+n);

            int[] orginalArray=new int[n];
            int[] result = new int[orginalArray.Length];

            for(i = 0; i < orginalArray.Length; i++)
            {
                Console.WriteLine("\nEnter Values for Index["+i+"]");
                orginalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nOriginal Array is ");
            for (i = 0; i < orginalArray.Length; i++)
            {
                Console.Write(orginalArray[i] + " ");
            }

            for (i = 0; i < orginalArray.Length; i++)   
            {
                result[i] = orginalArray[orginalArray.Length - i - 1];
            }

            Console.Write("\nReversed Array is ");
            reverseArray(result, orginalArray.Length);

            //orginalArray = int.Parse();
            //int len = orginalArray.Length;

            //int[] result=new int[len];
            //int i;

            //for (i = 0; i < len; i++)   
            //{
            //    result[i] = orginalArray[len - i - 1];
            //}

            //reverseArray(result,len);
        }
    }
}
