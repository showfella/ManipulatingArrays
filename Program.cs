using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {0,2,4,6,8,10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

           double meanA = Average(A);
           double meanB =  Average(B);
           double meanC = Average(C);



            Console.WriteLine("Average of Array A is {0}", meanA);
            Console.WriteLine("Average of Array B is {0}", meanB);
            Console.WriteLine("Average of Array C is {0}", meanC);


            Console.WriteLine("Reverse Array A is:");
            ReverseArray(A);
            Console.WriteLine("Reverse Array B is:");
            ReverseArray(B);
            Console.WriteLine("Reverse Array C is:");
            ReverseArray(C);

            Console.WriteLine("Sorted Array A is :");
            SortArray(A);

            Console.WriteLine("Sorted Array B is :");
            SortArray(B);

            Console.WriteLine("Sorted Array C is :");
            SortArray(C);

            Console.WriteLine("Rotate array C by 2 is :");
            RotateArray(C, 2);

            Console.WriteLine("Rotate array A by 4 is :");
            RotateArray(A, 4);

            Console.WriteLine("Rotate array B by 3 is :");
            RotateArray(B, 3);
  
           

        }
        public static double Average(int[] a)
        {

            int count = 0;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = a[i] + sum;
                count++;
            }
            double compute = sum / count;
            return compute; 

        }

        public static void ReverseArray(int[] a)
        {
            
            for(int i = a.Length-1 ; i >= 0; i--)
            {
                Console.Write(a[i]+",");
            }

            Console.WriteLine();
            
        }

        public static void SortArray(int[] a)
        {
           
            for (int i = a.Length; i > 0; i--)
            {
                bool sorted = false;
                for (int j = 0; j < i - 1; j++)
                {
                    if(a[j ]> a[j+1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        sorted = true;

                    }
                }
                if (!sorted) break;

            }

            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }

            Console.WriteLine();
        }

        public static void RotateArray(int[] a, int num)
        {
            if (num > a.Length)
            {
                Console.WriteLine("number of rotation cannot be greater than length of the array");

            }
            else
            {
                int[] temp = new int[a.Length];
                int j = 1;
                for (int i = 0; i < num; i++)
                {
                    //store value from 0 to num-1

                    temp[a.Length - j] = a[i];
                    j++;
                }
                int k = 0;
                while (num < a.Length)
                {
                    temp[k] = a[num];
                    k++;
                    num++;
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i] + ",");
                }

                Console.WriteLine();

            }
        }

    }
}
