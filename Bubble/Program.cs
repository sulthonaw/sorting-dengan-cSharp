namespace Sorting
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 18, 10, 10, 4, 5, 20, 4, 11, 15, 6, 2, 17, 8, 18, 16, 17, 16, 20, 4 };
            BubbleInt(numbers);
        }

        static void BubbleInt(int[] arr)
        {
            Console.WriteLine("\n== SEBELUM ==");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < (arr.Length - 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tampungan = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tampungan;
                    }
                }
            }

            Console.WriteLine("\n\n== SESUDAH ==\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
