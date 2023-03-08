namespace Sorting
{
    class Insertion
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 18, 10, 10, 4, 5, 20, 4, 11, 15, 6, 2, 17, 8, 18, 16, 17, 16, 20, 4 };
            InsertionInt(numbers);
        }

        static void InsertionInt(int[] arr)
        {
            Console.WriteLine("== SEBELUM ==");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (temp < arr[j] && j >= 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }

            Console.WriteLine("\n\n== SESUDAH ==");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}