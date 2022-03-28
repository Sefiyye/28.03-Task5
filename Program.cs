using System;

namespace _28._03_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 10, 15, 18, 20, 12 };
            int NumbersYouWillAdd = 16;
            ToAddANewElement(numbers, NumbersYouWillAdd);

        }
        public static void ToAddANewElement(int [] arr,int num)
        {
            Array.Resize(ref arr,arr.Length + 1);
            arr[arr.Length - 1] = num;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
