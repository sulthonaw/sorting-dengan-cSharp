namespace Sorting
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 18, 10, 10, 4, 5, 20, 4, 11, 15, 6, 2, 17, 8, 18, 16, 17, 16, 20, 4 };
            QuickInt(numbers);
        }

        public static void QuickInt(int[] angka)
        {
            Console.WriteLine("== SEBELUM ==");
            foreach (int Angka in angka)
            {
                Console.Write($"{Angka} ");
            }

            QuickIntAlgo(angka, 0, angka.Length - 1);

            Console.WriteLine("\n\n== SESUDAH ==");

            foreach (int Angka in angka)
            {
                Console.Write($"{Angka} ");
            }

        }

        public static void QuickIntAlgo(int[] angka, int indexAwal, int indexAkhir)
        {
            int i = indexAwal, j = indexAkhir;
            int pivot = angka[indexAwal];

            //perulangan untuk mengecek apakah data masih bisa dicek atau tidak
            while (i <= j)
            {
                //kalau nilai di sebelah kiri kurang dari nilai pivot 
                while (angka[i] < pivot) //kalau mau desc dibalik jadi >
                {
                    i++;
                }
                //kalau nilai di sebelah kanan lebih dari nilai pivot
                while (angka[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tampungan = angka[i];
                    angka[i] = angka[j];
                    angka[j] = tampungan;
                    i++;
                    j--;
                }
            }
            if (indexAwal < j)
            {
                QuickIntAlgo(angka, indexAwal, j);
            }

            if (i < indexAkhir)
            {
                QuickIntAlgo(angka, i, indexAkhir);
            }
        }
    }
}
