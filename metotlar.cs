using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public static class metotlar
    {
        public static int buyukHarf = 0;        //buyuk harf sayisini icinde tutacak degisken
        public static int kucukHarf = 0;        //kucuk harf sayisini icinde tutacak degisken
        public static int rakam = 0;            //rakam sayisini icinde tutacak degisken
        public static int sembol = 0;           //sembol sayisini icinde tutacak degisken
        public static int puan = 0;             //sifrenin puanini icinde tutacak degisken

        public static void sifirla()                         //yeniden sifre girilmesi durumunda eski verileri sifirlamak icin bir metod olusturdum.
        {
            buyukHarf = 0;
            kucukHarf = 0;
            rakam = 0;
            sembol = 0;
            puan = 0;
        }

        public static void BuyukHarfSayisi(string sifre)    //buyuk harf sayisini bulmak icin bir metod olusturdum.
        {
            char[] dizi = new char[sifre.Length];
            dizi = sifre.ToCharArray();                     //girilen sifrede buyuk harf olup olmadigini kontrol edebilmek icin sifreyi karakter dizisine cevirdim.

            for (int i = 0; i < sifre.Length; i++)          //karakter dizisinde buyuk harf var mi diye kontrol edebilmek icin 0'dan baslayan ve sifrenin uzunluguna kadar sirayla giden bir for dongusu olusturdum.
            {
                bool sonuc = Char.IsUpper(dizi[i]);         //buyuk harf olup olmadigini kontrol eden metodu kullandim ve sonucu bir bool degiskenine atadim.

                if (sonuc == true)                          //sonuc degiskenine atadigim deger eger dogruysa yani sifrede buyuk harf varsa buyuk harf sayisini icinde tutan buyukHarf degiskenini 1 arttir.
                    buyukHarf++;                
            }

            if (buyukHarf == 1)                             //eger buyuk harf sayisi 1 ise sifre puanina 10 ekle, 2 ve 2'den fazla ise 20 puan ekle.
                puan += 10;
            if (buyukHarf >= 2)
                puan += 20;

            Console.WriteLine("Sifredeki buyuk harf sayisi: " + buyukHarf);     
        }

        public static void KucukHarfSayisi(string sifre)        //kucuk harf sayisini bulmak icin bir metod olusturdum.
        {
            char[] dizi = new char[sifre.Length];
            dizi = sifre.ToCharArray();                         //girilen sifrede kucuk harf olup olmadigini kontrol edebilmek icin sifreyi karakter dizisine cevirdim.

            for (int i = 0; i < sifre.Length; i++)              //karakter dizisinde kucuk harf var mi diye kontrol edebilmek icin 0'dan baslayan ve sifrenin uzunluguna kadar sirayla giden bir for dongusu yaptim.
            {
                bool sonuc = Char.IsLower(dizi[i]);             //kucuk harf olup olmadigini kontrol eden metodu kullandim ve sonucu bir bool degiskenine atadim.

                if (sonuc == true)                              //eger sifrede kucuk harf varsa kucuk harf sayisini icinde tutan kucukHarf degiskenini 1 arttir.
                    kucukHarf++;                
            }

            if (kucukHarf == 1)                                 //eger kucuk harf sayisi 1 ise sifre puanina 10 ekle, 2 ve 2'den fazla ise 20 puan ekle.
                puan += 10;
            if (kucukHarf >= 2)
                puan += 20;

            Console.WriteLine("Sifredeki kucuk harf sayisi: " + kucukHarf);   
        }

        public static void RakamSayisi(string sifre)    //sifredeki rakam sayisini bulmak icin bir metod olusturdum.
        {
            char[] dizi = new char[sifre.Length];
            dizi = sifre.ToCharArray();                 //girilen sifrede rakam olup olmadigini kontrol edebilmek icin sifreyi karakter dizisine cevirdim.

            for (int i = 0; i < sifre.Length; i++)      //karakter dizisinde rakam var mi diye kontrol edebilmek icin 0'dan baslayan ve sifrenin uzunluguna kadar sirayla giden bir for dongusu yaptim.
            {
                bool sonuc = Char.IsDigit(dizi[i]);     //rakam olup olmadigini kontrol eden metodu kullandim ve sonucu bir bool degiskenine atadim.

                if (sonuc == true)                      //eger sifrede rakam varsa rakam sayisini icinde tutan rakam degiskenini 1 arttir.
                    rakam++;              
            }

            if (rakam == 1)                             // eger rakam sayisi 1 ise sifre puanina 10 ekle, 2 ve 2'den fazla ise 20 puan ekle.
                puan += 10;
            if (rakam >= 2)
                puan += 20;

            Console.WriteLine("Sifredeki rakam sayisi: " + rakam);      
        }

        public static void SembolSayisi(string sifre)                    //sifredeki sembol sayisini bulmak icin bir metod olusturdum.
        {
            char[] dizi = new char[sifre.Length];
            dizi = sifre.ToCharArray();                                  //girilen sifrede sembol olup olmadigini kontrol edebilmek icin sifreyi karakter dizisine cevirdim.

            for (int i = 0; i < sifre.Length; i++)                       //karakter dizisinde sembol var mi diye kontrol edebilmek icin 0'dan baslayan ve sifrenin uzunluguna kadar sirayla giden bir for dongusu yaptim.
            {
                bool sonuc = Char.IsPunctuation(dizi[i]);                //noktalama isaretleri olup olmadigini kontrol eden metodu kullandim ve sonucu sonuc degiskenine atadim.
                bool sonuc2 = Char.IsSymbol(dizi[i]);                    //sembol olup olmadigini kontrol eden metodu kullandim ve sonucu sonuc2 degiskenine atadim.
                if (sonuc == true || sonuc2 == true)                     //eger sifrede sembol (veya noktalama isareti) varsa sembol (ve noktalama isareti) sayisini icinde tutan sembol degiskenini 1 arttir.
                    sembol++;
            }

            puan += sembol * 10;                                         //sifredeki her sembol icin puani 10 arttir.
            Console.WriteLine("Sifredeki sembol sayisi: " + sembol);    
        }
    }
}
