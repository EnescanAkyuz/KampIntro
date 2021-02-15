using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Name = "Deluxe 5A ";
            urun1.Processor = "Ryzen 5 3600 ";
            urun1.Price = 11300;

            Product urun2 = new Product();
            urun2.Name = "Deluxe 5T10 ";
            urun2.Processor = "i5 10400f ";
            urun2.Price = 11270;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product list in urunler)
            {
                Console.WriteLine("ÜRÜN ADI: " + list.Name + "-" + "ÜRÜNDEKİ İŞLEMCİ: " + list.Processor + "ÜRÜN FİYATI: " + list.Price);
            }

            Console.WriteLine("********while*********");

            int sayac = 0;
            while (sayac < urunler.Length)
            {
                Console.WriteLine("ÜRÜN ADI: " + urunler[sayac].Name + "-" + "ÜRÜNDEKİ İŞLEMCİ: " + urunler[sayac].Processor + "ÜRÜN FİYATI: " + urunler[sayac].Price);
                sayac++;
            }




        }
    }
    class Product
    {
        public string Name { get; set; }
        public string Processor { get; set; }
        public int Price { get; set; }
    }
}
