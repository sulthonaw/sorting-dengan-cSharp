namespace Sorting
{
    class Merge
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 18, 10, 10, 4, 5, 20, 4, 11, 15, 6, 2, 17, 8, 18, 16, 17, 16, 20, 4 };
            MergeSort(numbers);
        }

        //procedure MergeSort
        public static void MergeSort(int[] bilangan)
        {
            Console.WriteLine("===SEBELUM==");
            foreach (int i in bilangan)
            {
                Console.Write($"{i} ");
            }

            bilangan = pisahInt(bilangan);

            Console.WriteLine("\n===SESUDAH==");
            foreach (int i in bilangan)
            {
                Console.Write($"{i} ");
            }
        }

        //function pisahInt
        public static int[] pisahInt(int[] bilangan)
        {
            //kalau datanya sudah menjadi satuan
            if (bilangan.Length <= 1)
            {
                //langsung kembalikan array
                return bilangan;
            }
            int nilaiTengah = bilangan.Length / 2;
            int[] kiri = new int[nilaiTengah];
            int[] kanan;

            //cek apakah data array ganjil atau genap
            if (bilangan.Length % 2 == 0)
            {
                kanan = new int[nilaiTengah];
            }
            else
            {
                kanan = new int[nilaiTengah + 1];
            }

            //isi array sisi kiri
            for (int i = 0; i < kiri.Length; i++)
            {
                kiri[i] = bilangan[i];
            }

            //isi array sisi kanan
            for (int i = 0; i < kanan.Length; i++)
            {
                kanan[i] = bilangan[nilaiTengah + i];
            }

            //lakukan pemanggilan fungsi ini untuk memisah sisi kanan dan kiri lagi
            kiri = pisahInt(kiri);
            kanan = pisahInt(kanan);

            //siapin array untuk menampung pengembalian array dari fungsi gabung
            int[] hasil = new int[bilangan.Length];

            //isi array hasil dari data yang sudah digabung
            hasil = gabungInt(kiri, kanan);

            //kembalikan
            return hasil;
        }

        //function gabungInt
        public static int[] gabungInt(int[] kiri, int[] kanan)
        {
            int[] hasilGabung = new int[kiri.Length + kanan.Length];

            int indexKiri = 0, indexKanan = 0, indexHasilGabung = 0;

            //perulangan untuk mengisi array hasil gabung
            while (indexKiri < kiri.Length || indexKanan < kanan.Length)
            {
                //cek apakah sisi kiri dan kanan masih ada/belum dibandingkan
                if (indexKiri < kiri.Length && indexKanan < kanan.Length)
                {
                    if (kiri[indexKiri] < kanan[indexKanan])
                    {
                        hasilGabung[indexHasilGabung] = kiri[indexKiri];
                        indexHasilGabung++;
                        indexKiri++;
                    }
                    else
                    {
                        hasilGabung[indexHasilGabung] = kanan[indexKanan];
                        indexHasilGabung++;
                        indexKanan++;
                    }

                }
                else if (indexKiri < kiri.Length)
                {
                    //kalau hanya sisi kiri saja yang masih tersedia
                    hasilGabung[indexHasilGabung] = kiri[indexKiri];
                    indexHasilGabung++;
                    indexKiri++;
                }
                else if (indexKanan < kanan.Length)
                {
                    hasilGabung[indexHasilGabung] = kanan[indexKanan];
                    indexHasilGabung++;
                    indexKanan++;
                }
            } //akhir while

            //kembalikan nilai array gabung
            return hasilGabung;
        }
    }
}