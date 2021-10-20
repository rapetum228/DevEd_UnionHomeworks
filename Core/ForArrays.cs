using System;

namespace Core
{
    public class ForArrays
    {
        public void ShowMeAnArrayAnScreen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }
    }
}
