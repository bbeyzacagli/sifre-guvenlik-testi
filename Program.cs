/********************************************************************************************************************
**				                                                           SAKARYA ÜNİVERSİTESİ
**				                                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				                                                      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ        
**				                                                     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					                                                      2021-2022 BAHAR DÖNEMİ
**	
**				                                            ÖDEV NUMARASI.......: 1
**				                                            ÖĞRENCİ ADI.........: BEYZA ÇAĞLI
**				                                            ÖĞRENCİ NUMARASI....: B211210084
**                                                          DERSİN ALINDIĞI GRUP: 1A
*
********************************************************************************************************************/



using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        { 

            while (metotlar.puan < 70)                         //sifrenin puani 70'ten kucuk olursa sifreyi yeniden almak icin while dongusu kullandim.
            {
                string sifre;                                  
                Console.Write("Sifrenizi giriniz: ");
                sifre = Console.ReadLine();
                Console.WriteLine();
                string bosluk = " ";                           //sifrede bosluk olup olmadigini kontrol edebilmek icin bir bosluk metni tanimladim.
                char[] rakamdizisi = new char[sifre.Length];        
                rakamdizisi = sifre.ToCharArray();             //sifredeki buyuk ve kucuk harfleri, rakamlari ve sembolleri kontrol edebilmek icin sifreyi karakter dizisine cevirdim.
                metotlar.BuyukHarfSayisi(sifre);               //asagidaki while dongusunun kontrolunde ihtiyacim olan buyuk ve kucuk harfleri, rakamlari ve sembolleri kullanabilmek icin metotlar sinifindan gerekli metotlari cagirdim.
                metotlar.KucukHarfSayisi(sifre);
                metotlar.SembolSayisi(sifre);
                metotlar.RakamSayisi(sifre);

                while (sifre.Length < 9 || sifre.Length > 10 || sifre.Contains(bosluk) == true || metotlar.buyukHarf == 0 || metotlar.kucukHarf == 0 || metotlar.rakam == 0 || metotlar.sembol == 0)    
                    //sifrede olmamasi gereken sartlari yazdim. bir tanesi bile sifrede saglanirsa sifre hatali olacak ve dogru sifre girilene kadar yeni sifre alinacak.
                {
                    Console.WriteLine();
                    Console.WriteLine("Hatali sifre girdiniz. Tekrar deneyiniz.");
                    Console.WriteLine();
                    metotlar.sifirla();
                    Console.Write("Sifrenizi giriniz: ");
                    sifre = Console.ReadLine();
                    Console.WriteLine();
                    metotlar.BuyukHarfSayisi(sifre);
                    metotlar.KucukHarfSayisi(sifre);
                    metotlar.SembolSayisi(sifre);
                    metotlar.RakamSayisi(sifre);
                }

                if (sifre.Length == 9)                                          //sifre 9 karakterli ise sifre puanina 10 puan ekledim.
                    metotlar.puan += 10;

                Console.WriteLine("Sifrenin puani: " + metotlar.puan);      

                if (metotlar.puan > 70 && metotlar.puan < 90)                  //sifrenin puani 70 ile 90 arasindaysa sifreyi kabul ettim.
                { 
                    Console.WriteLine("Sifre kabul edildi.");
                    break;                                                      //donguden cikabilmek icin break kullandim.
                }
                
                if (metotlar.puan >= 90 && metotlar.puan <= 100)                //sifrenin puani 90 ile 100 arasinda ise sifreyi kabul ettim.
                { 
                    Console.WriteLine("Guclu sifre, sifre kabul edildi.");
                    break;                                                      //donguden cikabilmek icin break kullandim.
                }
                
                if (metotlar.puan <= 70)                                         //sifrenin puani 70'ten kucukse sifre zayif oldugu icin yeniden sifre istedim.
                {
                    Console.WriteLine();
                    Console.WriteLine("Sifre zayif. Tekrar deneyiniz.");
                    Console.WriteLine();
                }

                metotlar.sifirla();                                             //tekrar sifre girilmesi durumunda puani, buyuk harfi, kucuk harfi, rakami ve sembolu sifirlamak icin sifirla metodunu cagirdim.
            }

            Console.ReadKey();                                                  //ekranin kapanmamasi icin
        }
    }
}

