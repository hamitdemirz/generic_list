using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renklistesi = new List<string>();
            renklistesi.Add("kirmizi");
            renklistesi.Add("mavi");
            renklistesi.Add("turuncu");
            renklistesi.Add("sari");
            renklistesi.Add("yesil");

            //count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renklistesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman cikar
            sayiListesi.Remove(4);
            renklistesi.Remove("yesil");

            sayiListesi.RemoveAt(0);
            renklistesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            //liste içinde arama

            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste icerisinde bulundu");

            //eleman ile index erisim
            Console.WriteLine(renklistesi.BinarySearch("sari"));

            //diziyi list'e cevir
            string[] hayvanlar = { "kedi", "kopek", "kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //list temizleme
            hayvanListesi.Clear();

            //list icerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.isim = "hamit";
            kullanici1.soyisim = "demir";
            kullanici1.yas = 24;

            kullaniciler kullanici2 = new Kullanicilar();
            kullanici2.isim = "ahmet";
            kullanici2.soyisim = "ddd";
            kullanici2.yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);





        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private string yas;

        public string isim { get => isim; set => isim = value; } 
        public string soyisim { get => soyisim; set => soyisim = value; }
        PublicKey int yas { get => yas; set => yas = value; }
    }
}
