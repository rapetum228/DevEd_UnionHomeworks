using System;

namespace Core
{
    public class Helper
    {
        public void ShowMeAnArrayAnScreen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        public void SwapTheVariables(ref int a, ref int b)
        {
            int copyA = a;
            a = b;
            b = copyA;
        }
    }
}
