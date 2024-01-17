using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrayExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            Console.ReadLine();
        }

        public static int SumArray(int[] arr)
        {
            //int total = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    total += arr[i];
            //}
            //return total;

            return ((arr[arr.Length - 1] * (arr[arr.Length - 1] + 1))/2);
        }

        public static int SequnatialSearch(int[] arr, int size, int value)
        {
            for(int i = 0; i < size;i++)
            {
                if(value == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int size, int value)
        {
            int mid;
            int left = 0;
            int right = size - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (arr[mid] == value)
                {
                    return mid;
                }
                else if (arr[mid] < value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

    }
}
