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
    class OrtaSaha :Futbolcu  //futbolcu sınıfından türemiş bir sınıf oluşturduk.
    {
        private  double uzunTop;
        private  double ilkDokunus;         //uzunTop ilkDokunus uretkenlik topSurme metot tanımladık
        private  double uretkenlik;         //Tanımlandığı anda değeri verilebilir . 
        private  double topSurme;
        private  double ozelYetenek;



        public OrtaSaha(string AdSoyad , int FormaNo) : base(AdSoyad , FormaNo)  //base yani futbolcu clasından kalıtım aldık. kurucu.
        {
            Random rastgele = new Random();           //rastgele komutu

            uzunTop = rastgele.Next(60, 100);         // uzun top özelliği 60 ile 100 arasında rastgele bir değer bulablir.
            
            ilkDokunus = rastgele.Next(60, 100);      // ilkdokunus özelliği 60 ile 100 arasında rastgele bir değer bulablir.
            
            uretkenlik = rastgele.Next(60, 100);      // uretkenlik özelliği 60 ile 100 arasında rastgele bir değer bulablir.
            
            topSurme = rastgele.Next(60, 100);        // top surme özelliği 60 ile 100 arasında rastgele bir değer bulablir.
            
            ozelYetenek = rastgele.Next(60, 100);     // ozel yetenek özelliği 60 ile 100 arasında rastgele bir değer bulablir.
            

            
            
            
        }
        public override bool PasVer()      //passkor bölümü hesaplanır.
        {
            Double PasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + topSurme * 0.1 + sans * 0.1;

            if (PasSkor > 60)   //Eğer passkorun ortaya çıkan değeri 60 tan büyükse döndür(true). else: false döndür.

                return true;

            else                 //değeri döndürme komutları.

                return false;
        }




        public override bool GolVurusu()  //Golvuruşu hesaplamak için..
        {
        
       double GolSkor = yetenek * 0.3 + ozelYetenek * 0.2 + sut * 0.2 + ilkDokunus * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;  // sonucunda bir değer ortaya çıkar.

            if (GolSkor > 70)   //Eğer Golskorun ortaya çıkan değeri 70 ten büyükse döndür(true). else: false döndür.

                return true;

            else                             //değeri döndürme.
                return false;

        }






    }
}
