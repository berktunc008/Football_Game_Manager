/********************************************************************************************************************
**                                              SAKARYA ÜNİVERSİTESİ 
**                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                                      NESENEYE DAYALI PROGRAMLAMA DERSİ
**                                           2018-2019 BAHAR DÖNEMİ
**
**
**                                           ÖDEV NUMARASI:PROJE TASARIM/3
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
    class Forvet : Futbolcu     //futbolcu sınıfından türmeiş bir sınıf olduşturduk.
    {

        private double bitiricilik;          //// tanımlamalar yapıldı.
        private double ilkDokunus;
        private double kafa;
        private double ozelYetenek;
        private double sogukKanlilik;

        public Forvet(string AdSoyad , int FormaNo) : base(AdSoyad,FormaNo) // base yani futbolcu Classından kalıtım aldık.
        {
            Random rastgeledeger = new Random();
            bitiricilik = rastgeledeger.Next(70, 100);      //yazan özelliklere rastgele 70 ile 100 arasında rastgele değerler atanır.
            ilkDokunus = rastgeledeger.Next(70, 100);
            kafa = rastgeledeger.Next(70, 100);
            ozelYetenek = rastgeledeger.Next(70, 100);
            sogukKanlilik = rastgeledeger.Next(70, 100);

        }


        public override bool PasVer()  //passkor bölümü hesaplanır.
        {

            double PasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            if (PasSkor > 60) ////eğer passkorun ortaya çıkan değeri 60 tan büyükse döndür(true). else: false döndür.
            {
                return true;
            }                       //değeri döndürme komutları.
            else
                return false;

        }


        public override bool GolVurusu()  //Golvurusu hesaplanır.
        {

            double GolSkor = yetenek * 0.2 + ozelYetenek * 0.2 + sut * 0.1 + kafa * 0.1 + ilkDokunus * 0.1 + bitiricilik * 0.1 + sogukKanlilik * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            if (GolSkor>70)  //Eğer Golskorun ortaya çıkan değeri 70 ten büyükse döndür(true). else: false döndür.
            {
                return true;
            }                          //değeri döndürme komutları.
            else
                return false;

        }






    }
}
