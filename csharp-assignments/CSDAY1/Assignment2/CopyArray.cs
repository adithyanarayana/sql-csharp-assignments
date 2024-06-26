using System;


namespace Assignment2
{
    public class CopyArray
    {
        public static void Main(string[] args) {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int [a.Length];   // length of arry from a[] 

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];

            }
            foreach (int i in a)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            foreach (int i in b)
            {
                Console.Write(i);
            }


        }
    }
}
