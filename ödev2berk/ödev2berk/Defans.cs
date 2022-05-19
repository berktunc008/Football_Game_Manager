/********************************************************************************************************************
**                                              SAKARYA ÜNİVERSİTESİ 
**                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                                      NESENEYE DAYALI PROGRAMLAMA DERSİ
**                                           2018-2019 BAHAR DÖNEMİ
**
**
**                                            ÖDEV NUMARASI:PROJE TASARIM/3
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
    class Defans : Futbolcu   ////futbolcu sınıfından türemiş bir sınıf oluşturduk.
    {
        private readonly double pozisyonAlma;
        private readonly double kafa;
        private readonly double sicrama;          // tanımları yapıldı.


        public Defans(string AdSoyad , int FormaNo) : base(AdSoyad , FormaNo) //base yani futbolcu clasından kalıtım aldık.
        {
            Random rastgeledeger = new Random();  // rastgele değer atama .

            pozisyonAlma = rastgeledeger.Next(50, 90);
            kafa = rastgeledeger.Next(50, 90);           //özelliklere 50 ile 90 arasında bir sayı döndürerek değer atadı.
            sicrama = rastgeledeger.Next(50, 90);


        }

        public override bool PasVer()  //Passkor bölümü hesaplama.(override diğer classlardaki bu özelliği yok sayıyor bunu alıyor)
        {
            double PasSkor = pas * 0.3 + yetenek * + dayaniklilik * 0.1 + dogalForm * 0.1 + pozisyonAlma * 0.1 + sans * 0.2;

            if (PasSkor > 60)    //eğer passkorun ortaya çıkan değeri 60 tan büyükse döndür(true). else: false döndür.

                return true;

            else                      //değeri döndürme komutları.

                return false;
        }

        public override bool GolVurusu()   //Golvurusu hesaplanır.

        {
            double GolSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + kafa * 0.1 + sicrama * 0.1 + sans * 0.1;   // sonucunda bir değer ortaya çıkar.

            if (GolSkor > 70)      //Eğer Golskorun ortaya çıkan değeri 70 ten büyükse döndür(true). else: false döndür.

                return true;

            else             //Değeri döndürme komutları.

                return false;
        }





    }
}
