namespace _5_11_odev
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kategori girin (Bilim Kurgu için 0, DunyaKlasiklari için 1, Psikoloji için 2):");
            string kategoriInput = Console.ReadLine().ToLower();

            KitapKategori kategori;

            if (Enum.TryParse(kategoriInput, out kategori))
            {
                switch (kategori)
                {
                    case KitapKategori.BilimKurgu:
                        Console.WriteLine("Bilim kurgu kategorisindeki kitaplar: A reyonundadır.");
                        break;

                    case KitapKategori.DunyaKlasiklari:
                        Console.WriteLine("Dünya klasikleri kategorisindeki kitaplar: B reyonundadır.");
                        break;

                    case KitapKategori.Psikoloji:
                        Console.WriteLine("Psikoloji kategorisindeki kitaplar: C reyonundadır.");
                        break;

                    default:
                        Console.WriteLine("Geçersiz kategori.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz kategori. Lütfen tekrar deneyin.");
            }
        }
        enum KitapKategori
        {
            BilimKurgu = 0,
            DunyaKlasiklari = 1,
            Psikoloji = 2
        }
    }
}
