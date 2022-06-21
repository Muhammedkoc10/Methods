using System;

namespace _5_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metot Nedir?

            /*Programın herhangi bir yerinde kullanmak için belirli bir işi yerine getirmek amacıyla tasarlanmış alt programlardır. 
            * Parametreler ---> Metot gövdesi -----> Geri dönüş değeri 
            * Tanımladığımız metotlara mümkn olduğunca az görev verilmelidir.
            * Bir metot az ve öz iş yapmalıdır.
            */

            // Metot Bildirimi
            /* [erişim belirleyici]<geri dönüş değeri> Metotİsmi (Parametre listesi)
                  {
                     metot gövdesi
                  }
            
             */

            // Örnek1 : "BilgeAdam" kelimesini ekrana 10 defa yazan programı 



            //YazOnKere();



            //// Örnek2 : Çarpma ve toplama işlemlerini iki ayrı metotta yapan programı yazınız

            //Toplama(12, 3);
            //Carpma(12, 3);



            //// Örnek3 : KareAl metodu ile iki sayının karesini aldıran program

            //KareAl(5);

            //// Örnek4 : 1'den 100 e kadar sayıları ekrana yazdıran metodu çağıran program

            //BirdenYuze();

            //// Metot Örnek 5: 1'den başlayan ve dışarıdan gönderilen değere kadar ekrana yazdıran metodu çağıran program.(void)

            //Console.WriteLine("..... 'ya kadar yazdırmak istediğiniz sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //SayiSaydir(sayi3);


            //// Metot Örnek 6: Kullanıcının girdiği iki sayıyı toplayan ve bu toplamın küpünü geriye döndüren metodu çağıran program...

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi5 = Convert.ToInt32(Console.ReadLine());

            //int toplam = ToplaVeKupAl(sayi4, sayi5);
            //Console.WriteLine(toplam);


            //// Metot Örnek 7: Kullanıcıdan öğrenilen sayının tek mi çift mi olduğunu söyleyen bir metodu çağıran program..

            //Console.WriteLine("Bir sayıyı giriniz");
            //int sayi6 = Convert.ToInt32(Console.ReadLine());
            //TekmiCiftmi(sayi6);



            ////Metot Örnek 8: Çarpma ve toplama işlemlerini iki ayrı metotta yapan, fakat çarpma metodunu, topla metodunda çağıran program

            //Toplama(12, 3);



            //// Metot Örnek 9: Klavyeden kullanıcı tarafından girilen iki sayıdan büyük olanı metot içinde bulup sonucu ana metotta ekrana yazdıran programı yazınız.(Bir metotta iki sayı karşılaştırılsın diğer metotta ilk metotu kullanarak çıkan sayı ile kalan sayı karşılaştırısın ana metotda ikinci metot kullanılsın)

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi7 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi8 = Convert.ToInt32(Console.ReadLine());

            //İlkKarsilastirma(sayi7, sayi8);
            //int kalanSayi = Math.Abs(sayi7 - sayi8);


            //int donen1 = İlkKarsilastirma(sayi7, sayi8);
            //İkinciKarsilastirma(kalanSayi, donen1);



            ////Metot Örnek 10: Klavyeden kullanıcı tarafından girilen üç sayıdan küçük olanı bulan programı, bir metodun başka bir metot tarafından çağrılması ile yazınız

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi10 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi11 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üçüncü sayıyı giriniz");
            //int sayi12 = Convert.ToInt32(Console.ReadLine());

            //İkiSayiKarsilastir(sayi10, sayi11);
            //int karsilastirilanSayi = İkiSayiKarsilastir(sayi10, sayi11);

            //UcuncuSayiyiKarsilastir(karsilastirilanSayi, sayi12);


            ////Metot Örnek 11: Klavyeden girilen açı değerlerinin sin, cos, tan, cot değerlerini ayrı ayrı metotlarda bulan programı yazınız.
            //// (Örn.Sin(int x) metodu tanımlayın içinde int sonuc = Math.Sin(x * Math.PI / 180) kullanarak)

            //Console.WriteLine("Bir açı değeri giriniz");
            //double aciDegeri = Convert.ToDouble(Console.ReadLine());

            //SinHesapla(aciDegeri);
            //cosHesapla(aciDegeri);
            //tanHesapla(aciDegeri);
            //cotHesapla(aciDegeri);

            //// Metot Örnek 12 : Ana metotta tanımlanan bir dizi metoda gönderen ve dizi elemanlarını ekrana yazdıran program.

            //int[] sayilar = {1, 22, 333, 4444, 55555 };

            //Gonder(sayilar);

            //// Metot Örnek 13 : Metotta tanımlanan 10 elamanlı bir diziye rastgele 1-20 arasında sayılar atandıktan sonra dizi içerisindeki en büyük değerini ve dizinin ortalama değerini iki ayrı metotta bulup yazan program.

            Random rnd = new Random();

            int[] rastgeleDizi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                rastgeleDizi[i] = rnd.Next(1, 21);

            }

            DiziEnBuyukDeger(rastgeleDizi);
            DiziOrtalama(rastgeleDizi);



            Console.ReadLine();

        }

        private static void DiziOrtalama(int[] rastgeleDizi)
        {
            int toplam = 0;
            foreach (int sayi in rastgeleDizi)
            {
                toplam = toplam + sayi;
            }
            int ortalama = toplam / 10;
            Console.WriteLine("Sayıların Ortalamaları = "+ortalama);
        }

        private static void DiziEnBuyukDeger(int[] rastgeleDizi)
        {
            int enBuyuk = rastgeleDizi[0];
            foreach (int sayi in rastgeleDizi)
            {
                if (sayi>enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            Console.WriteLine("En büyük sayı = " +enBuyuk);
        }

        private static void Gonder(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            
        }

        private static void cotHesapla(double aciDegeri)
        {
            double sonuc =1 / (Math.Tan(aciDegeri * Math.PI / 180));
            Console.WriteLine(sonuc);
        }

        private static void tanHesapla(double aciDegeri)
        {
            double sonuc = Math.Tan(aciDegeri * Math.PI / 180);
            Console.WriteLine(sonuc);
        }

        private static void cosHesapla(double aciDegeri)
        {
            double sonuc = Math.Cos(aciDegeri * Math.PI / 180);
            Console.WriteLine(sonuc);
        }

        private static void SinHesapla(double aciDegeri)
        {
            double sonuc = Math.Sin(aciDegeri * Math.PI / 180);
            Console.WriteLine(sonuc);
        }

        private static void UcuncuSayiyiKarsilastir(int sayi1, int sayi2)
        {
            if (sayi1 < sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }
        }

        public static int İkiSayiKarsilastir(int sayi10, int sayi11)
        {
            if (sayi10<sayi11)
            {
                return sayi10;
            }
            else
            {
                return sayi11;
            }
        }

        public static void İkinciKarsilastirma(int kalanSayi, int  ilkKarsilastirma)
        {
            if (kalanSayi<ilkKarsilastirma)
            {
                Console.WriteLine(ilkKarsilastirma);
            }
            else
            {
                Console.WriteLine(kalanSayi);
            }
        }

        public static int İlkKarsilastirma(int sayi7, int sayi8)
        {
            if (sayi7>sayi8)
            {
                return sayi7;
            }
            else
            {
                return sayi8;
            }
        }

        public static void TekmiCiftmi(int sayi6)
        {
            if (sayi6 % 2 == 0)
            {
                Console.WriteLine("Çifttir");
            }
            else
            {
                Console.WriteLine("Tektir");
            }
        }

        public static int ToplaVeKupAl(int sayi4, int sayi5)
        {
            return (sayi4 + sayi5) * (sayi4 + sayi5) * (sayi4 + sayi5);

        }

        public static void SayiSaydir(int gelenSayi)
        {
            for (int i = 1; i <= gelenSayi; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void BirdenYuze()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void KareAl(int sayi1)
        {
            Console.WriteLine(sayi1 * sayi1);
        }

        public static void Carpma(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 * sayi2);
        }

        // Metot Örnek 8: Çarpma ve toplama işlemlerini iki ayrı metotta yapan, fakat çarpma metodunu, topla metodunda çağıran program
        public static void Toplama(int sayi1, int sayi2)
        {
            Carpma(sayi1, sayi2);
            Console.WriteLine(sayi1 + sayi2);
        }

        public static void YazOnKere()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bilge Adam");
            }

        }

        public int SayiTopla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
