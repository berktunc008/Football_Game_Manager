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
    class Futbolcu
    {
        public string adSoyad;              //public erişim!
        public int formaNo;                

        protected double hiz;
        protected double dayaniklilik;
        protected double pas;
        protected double sut;                    // tanımlamalar yapıldı. Base yani futbolcu classındaki özellikleri kalıtım ile diğer forvet defans,
        protected double yetenek;                //ortasaha classlarında da ortak olarak kullanacağız.
        protected double kararlilik;
        protected double dogalForm;
        protected double sans;


        public Futbolcu(string AdSoyad, int FormaNo)        // kurucu metot oluşturulur.
        {
            Random rastgelesayi = new Random();
            hiz = rastgelesayi.Next(50, 100);
            dayaniklilik = rastgelesayi.Next(50, 100);
            pas = rastgelesayi.Next(50, 100);
            sut = rastgelesayi.Next(50, 100);                  //Yazan özelliklere rastgele 50 ile 100 arasında rastgele değerler atanır.
            yetenek = rastgelesayi.Next(50, 100);
            kararlilik = rastgelesayi.Next(50, 100);
            dogalForm = rastgelesayi.Next(50, 100);
            sans = rastgelesayi.Next(50, 100);
            this.adSoyad = AdSoyad;
            this.formaNo = FormaNo;

        }

        public virtual bool PasVer()    //passkor bölümü hesaplanır.
        {
            double PasSkor = pas * 0.3 + yetenek * 0.3 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.2;    // sonucunda bir değer ortaya çıkar.

            if (PasSkor > 60)        //eğer passkorun ortaya çıkan değeri 60 tan büyükse döndür(true). else: false döndür.
                 
            {
                return true;         //değeri döndürme komutları.
            }
            else
            {
                return false;
            }

        }
    
    public virtual bool GolVurusu()   //Golvurusu hesaplanır.
    {
        double GolSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + hiz * 0.1 + sans * 0.2;    // sonucunda bir değer ortaya çıkar.

            if (GolSkor > 70) //Eğer Golskorun ortaya çıkan değeri 70 ten büyükse döndür(true). else: false döndür.

            {
            return true;
          }

            else                     //değeri döndürme komutları.
            {
            return false;
        }

    }



    }
}
