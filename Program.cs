using System;

namespace Odev
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ---------Ödev 1---------- -

           Console.WriteLine("==== Ödev 1 ====");

            Console.WriteLine("Lütfen sayı miktarını giriniz: ");
            int a = 0;
            int sayiMiktari = 1;
            bool checkNegativeNumbers = false;
            while (a < 1)
            {
                sayiMiktari = int.Parse(Console.ReadLine());
                Metotlar.PozitifSayiKontrol(sayiMiktari);
                if (sayiMiktari <= 0)              
                    break;
                                
                int[] sayiDizisi1 = new int[sayiMiktari];

                Console.WriteLine("Lütfen kontrol etmek istediğiniz pozitif sayıları giriniz: ");
                while (a < 1)
                {
                    for (a = 0; a < sayiMiktari; a++)
                    {
                        sayiDizisi1[a] = int.Parse(Console.ReadLine());
                    }

                    foreach (int sayi in sayiDizisi1)
                    {
                        if (sayi < 0)
                            checkNegativeNumbers = true;
                    }

                    if (checkNegativeNumbers)
                    {
                        Console.WriteLine("Lütfen sadece pozitif sayılar giriniz.");
                        break;
                    }

                    Console.WriteLine("Dizinizdeki çift sayılar: ");
                    foreach (int sayi in sayiDizisi1)
                    {
                        if (sayi % 2 == 0)
                            Console.WriteLine(sayi);
                        else
                            continue;
                    }
                }
                a++;
            }

           // ---------Ödev 2---------- -

           Console.WriteLine("==== Ödev 2 ====");

            int b = 0;
            int kontrolEdilenSayi = 0;
            int sayiMiktari2 = 0;
            int eslesmeKontrol = 0;
            bool negatifSayiKontrol = false;


            while (b < 1)
            {
                Console.WriteLine("Lütfen ilk değeri giriniz: ");
                sayiMiktari2 = int.Parse(Console.ReadLine());
                Metotlar.PozitifSayiKontrol(sayiMiktari2);

                if (sayiMiktari2 <= 0)
                    break;

                Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
                kontrolEdilenSayi = int.Parse(Console.ReadLine());
                Metotlar.PozitifSayiKontrol(kontrolEdilenSayi);

                if (kontrolEdilenSayi <= 0)
                    break;
               
                int[] eslesenSayilar = new int[sayiMiktari2];
                int[] sayiDizisi2 = new int[sayiMiktari2];

                Console.WriteLine("Lütfen " + sayiMiktari2 + " adet pozitif sayı giriniz: ");

                for (b = 0; b < sayiMiktari2; b++)
                    sayiDizisi2[b] = int.Parse(Console.ReadLine());

                foreach (int sayi in sayiDizisi2)
                {
                    if (sayi <= 0)
                        negatifSayiKontrol = true;
                }

                if (negatifSayiKontrol)
                {
                    Console.WriteLine("Lütfen sadece pozitif değerler giriniz.");
                    break;
                }

                for (b = 0; b < sayiMiktari2; b++)
                {
                    if ((sayiDizisi2[b] == kontrolEdilenSayi) || (sayiDizisi2[b] % kontrolEdilenSayi == 0))
                    {
                        eslesenSayilar[b] = sayiDizisi2[b];
                        eslesmeKontrol += 1;
                    }
                    else if (eslesmeKontrol == 0)
                    {
                        Console.WriteLine("Değerlerden hiçbiri " + kontrolEdilenSayi + " sayısına bölünmüyor veya eşit değil.");
                        break;
                    }
                }

                if (eslesmeKontrol > 0)
                {
                    Console.WriteLine(kontrolEdilenSayi + " sayısına tam bölünen sayılar: ");
                    foreach (int sayi in eslesenSayilar)
                        Console.WriteLine(sayi);
                }

                b++;
            }

            // ---------Ödev 3---------- -

           Console.WriteLine("==== Ödev 3 ====");

            int c = 0;
            int sayiMiktari3 = 0;
            bool kelimeKontrolü = false;


            while (c < 1)
            {
                Console.WriteLine("Lütfen girmek istediğiniz kelime miktarını giriniz: ");
                sayiMiktari3 = int.Parse(Console.ReadLine());
                Metotlar.PozitifSayiKontrol(sayiMiktari3);

                if (sayiMiktari3 <= 0)
                    break;

                string[] kelimeDizisi = new string[sayiMiktari3];

                Console.WriteLine("Lütfen yazdırmak istediğiniz kelimeleri giriniz: ");
                for (c = 0; c < sayiMiktari3; c++)
                {
                    kelimeDizisi[c] = Console.ReadLine();
                }

                foreach (string kelime in kelimeDizisi)
                {
                    kelimeKontrolü = Metotlar.StringKontrol(kelime);
                    if (kelimeKontrolü)
                        break;
                }

                if (kelimeKontrolü)
                    break;

                Array.Reverse(kelimeDizisi);

                Console.WriteLine("Kelimelerinizin sondan başa doğru dizilişi: ");

                foreach (string kelime in kelimeDizisi)
                    Console.WriteLine(kelime);

                c++;
            }

            // --------- Ödev 4 -----------

            Console.WriteLine("==== Ödev 4 ====");

            int d = 0;

            while (d < 1)
            {
                Console.WriteLine("Lütfen bir cümle giriniz: ");
                string kelime = Console.ReadLine();
                bool kelimeKontrol2 = Metotlar.StringKontrol(kelime);

                if (kelimeKontrol2)
                    break;

                kelime = kelime.Replace(" ", "");

                Console.WriteLine("Cümlenizdeki harf ve karakter sayısı: " + kelime.Length);

                d++;
            }
        }
    }

    public static class Metotlar
    {
        public static int PozitifSayiKontrol(this int deger1)
        {
            if (deger1 <= 0)
            {
                Console.WriteLine("Lütfen sadece pozitif değerler giriniz.");
            }
             
                return deger1;
        }

        public static bool StringKontrol(this string deger1)
        {
            for (int i = 0; i < deger1.Length; i++)
            {
                bool check = Char.IsDigit(deger1, i);
                if (check)
                {
                    Console.WriteLine("Lütfen sadece harf giriniz.");
                    return true;
                }
            }
            return false;
        }
    }
}






