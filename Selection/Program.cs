namespace Sorting
{
    class Selection
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 18, 10, 10, 4, 5, 20, 4, 11, 15, 6, 2, 17, 8, 18, 16, 17, 16, 20, 4 };
            SelectionInt(numbers);
        }

        static void SelectionInt(int[] arr)
        {
            Console.WriteLine("== SEBELUM ==");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int pos = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[pos] > arr[j]) pos = j;
                }
                if (pos != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[pos];
                    arr[pos] = temp;
                }
            }

            Console.WriteLine("\n== SESUDAH ==");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}