using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adı = "İrem";
            musteri1.Soyadı = "Kara";
            musteri1.Id = 21;

           

            Musteri musteri2 = new Musteri();
            musteri2.Adı = "Birgül";
            musteri2.Soyadı = "Altındaş";
            musteri2.Id = 21;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adı);
                Console.WriteLine(musteri.Soyadı);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("-----");
            }



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("-----");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-----");

        }
    }
}
