/********************************************************************************************************************
**                                              SAKARYA ÜNİVERSİTESİ 
**                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                                      NESENEYE DAYALI PROGRAMLAMA DERSİ
**                                           2018-2019 BAHAR DÖNEMİ
**
**
**                                             ÖDEV NUMARASI:PROJE TASARIM/3
**                                               ÖĞRENCİ ADI:BERK TUNÇ
**                                                   NO:B171200016
**
**************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2berk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Futbolcu> galatasaray = new List<Futbolcu>();       //liste yönetimi ile kişileri forma numaraları ile sıraladık.
            galatasaray.Add(new Futbolcu("FERNANDO MUSLERA", 1));
            galatasaray.Add(new Defans("SERGİO RAMOS", 2));
            galatasaray.Add(new Defans("MALDİNİ", 5));
            galatasaray.Add(new Defans("MARCELO", 6));
            galatasaray.Add(new Defans("PUYOL", 8));                   //11 Kişilk KADRO OLUŞTURULDU.Adları ve forma numaraları eklendi.
            galatasaray.Add(new OrtaSaha("MESSİ", 10));                //takim listesine nesneler eklendi.
            galatasaray.Add(new OrtaSaha("SNEIJDER", 12));
            galatasaray.Add(new OrtaSaha("FELİPE MELO", 9));
            galatasaray.Add(new OrtaSaha("İNİESTA", 25));
            galatasaray.Add(new Forvet("DROGBA", 44));
            galatasaray.Add(new Forvet("RONALDO", 7));

            Random RastgeleSayi = new Random();     //rastgele sayı atama komutu.
            int oyuncuNo;  
            int eskiOyuncu = 0;   //ilk başta 0 olarak varsaydık.sonra atama işlemi yapılacak.

            oyuncuNo = RastgeleSayi.Next(1, 11);   //1 den 11 e kadar rasgele sayı üretiyoruz.

            Console.WriteLine("Hakem Düdüğü çalmak için yan hakeme baktı ve Santra çizgisinde Galatasaray.....\n");

            Console.WriteLine("{0} Oyunu Başlatıyor. \n", galatasaray[oyuncuNo].adSoyad);      //döndürülen değerdeki index ile oyun başlatılıyor. 

            Boolean gololabilir = true;



            for (int i = 1; i <= 3; i++)   //3 kez pas verilmesi lazım.
            {
                oyuncuNo = RastgeleSayi.Next(1, 11); // rastgele sayı üret.

                    while (oyuncuNo == eskiOyuncu)  // Eğer pas verilince sistem tekrar kendine pas attı sayarsa devam etme! (döngüye gir )yeni bir oyuncu seç.

                    {
                    oyuncuNo = RastgeleSayi.Next(1, 11); //Rastgele 1 den 11 e kadar numara seç.
                    }

                eskiOyuncu = oyuncuNo;

                if (!galatasaray[oyuncuNo].PasVer())   //Passkor değişkeni false döndürürse pas verilmez.
                {
                    gololabilir = false;   //gol olma ihtimali yok olur.
                    break;
                }
                else
                    Console.WriteLine("Pas {0} oyuncusuna veriliyor.\n", galatasaray[oyuncuNo].adSoyad);  // pas verilen oyuncuyu yazıyor.

            }

            if (gololabilir) // Gol olma ihtimali var ise.
            {
                galatasaray[oyuncuNo].GolVurusu();   //Oyuncu gol vuruşu yapar.

                if (galatasaray[oyuncuNo].GolVurusu() == true)  //golskor değişkeni true dönerse golvuruşu sağlanmış olur.
                {
                    Console.Write("{0} Vuruyor ve Müthiş bir GOLL.Galatasaray öne geçiyor.....", galatasaray[oyuncuNo].adSoyad);
                    Console.WriteLine("Forma No : {0}", galatasaray[oyuncuNo].formaNo);                       //ekrana gol olması durumunda yazılır .Forma no ile birlikte
                }               
                else
                    Console.WriteLine("{0} malesef kaçırıyor!", galatasaray[oyuncuNo].adSoyad);         //ekrana gol olmaması(kaçırılması) durumunda yazılır.kaçırınca Forma no yazılmaz.

            }



        }
    }
}
