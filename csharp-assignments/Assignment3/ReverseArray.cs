using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ReverseArray
    {
        public int[] GenerateNumbers(int len)
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        public void PrintNumbers(int[] number)
        {
            foreach (int i in number)
            {
                Console.Write(i);
            }
        }

        public void Reverse(int[] number)
        {
            int len = number.Length;
            for (int i = 0; i < len/2; i++)
            {
                int temp = number[i];
                number[i] = number[len - i - 1];
                number[len - i - 1] = temp;
            }

        }
    }
}
