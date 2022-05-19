# Football_Game_Manager



Bir futbol oyununda, oyun içinde çeşitli özellikler barından 4 defans 4 orta saha ve 2 forvet oyuncusu tasarlanmak istenmektedir.(Kaleci Yok)

Oyun için AdSoyad, FormaNo, Hiz, Dayaniklik, Pas, Sut, Yetenek,Kararlik, DogalForm  ve Sans özelliklerini barındarın bir futbolcu sınıfı tanımlanmalıdır. Bu futbolcu sınıfından defans,ortasaha ve forvet özelliklerinde 3 sınıf türetilmelidir. 

Defans oyuncusunda
- PozisyonAlma 
- Kafa 
- Sicrama

Orta Saha Oyuncusunda
- UzunTop
- IlkDokunus
- Uretkenlik
- TopSurme
- OzelYetenek

Forvet Oyuncusunda
- Bitiricilik
- IlkDokunus
- Kafa
- ÖzelYetenek
- SogukKanlilik

özeliklerinin olması istenmektedir. 

Yukarıda tanımlanan tüm özellikler, kendi sınıflarına ait kurucu fonksiyonlar tanımlandığında, tanımlı olduğu sınıfa göre aşağıdaki değerleri rastgele olarak alacaklardır.

Futbolcu sınıfı için oluştutulacak özellikler 50-100 arasında
Defans oyunuclarında oluşturulacak özellikler 50-90 arasında 
Orta saha oyuncuları için 60-100 arasında
Forvet oyuncuları için 70-100 arasında rastgele atanmalıdır.

Oyuna rastgele seçilecek bir oyuncu ile başlanmalı ve rastgele seçilen oyuncuya ait Pasver()  metodu çağrılmalıdır. Bu metod başarılı ise rastgele başka bir oyunucu seçilerek, ona pas verildiği varsayımı ile top ona geçmeli, oyun devam etmelidir. 

Bu olay  3 adet rastgele seçilen oyuncuya pas verilmesi şeklinde devam etmelidir.
Tüm Paslar başarlı olduysa 3 pasın sonunda  rastgele seçilen (pas verilen) oyuncu GolVurusu yapmalıdır. GolVurusu da başarılı ise GOLLLL, Oyuncu ismi ve sırt numarası ekrana yazılmalıdır. PasVer ve GolVurusu başarılı olmadıysa ekrana bu durumlara ait mesajlar basılmalıdır.

Not: Pasver Metodu başaılı ise rastgele seçilen oyuncunun pas veren oyuncu ile aynı olmamasına özen gösterilmelidir. (Oyuncu kendine pas veremez) 
Örnek Çalışma Durumu

Oyuncu seç =>Rastegele olarak 2 numaralı oyuncu seçildi

Pas Ver      =>2 Numaralı oyuncu için PasVer metodunu çağır Pasver başarılı Başka bir 		   oyuncu seç (Örnek: Rastgele olarak 5 nolu oyuncu seçildi) 

Pas Ver      => 5 numarlı oyuncu için PasVer metodunu çağır Pasver başarılı Başka bir 		   oyuncu seç (Örnek: Rastgele olarak 7 nolu oyuncu seçildi) 

Pas Ver      =>7 Numaralı oyuncu için PasVer metodunu çağır Pasver başarılı Başka bir 		  oyuncu seç (Örnek: Rastgele olarak 9 nolu oyuncu seçildi) 
		  Yukarıdaki PasVer metodlarının herhangi biri başarısız ise süreci   			 sonlandır ve durumu ekrana yaz.

GolVurusu  => 9 Nolu oyuncu için GolVurusu Metodunu çalıştır.


PasVer metodunun tanımlı olduğu sınıflara göre başarılı olma durumu   

Futbolcu sınıfı için

	PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 +
                         Sans * 0.2;
          

Defans sınıfı için

	PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 +   	          	                PozisyonAlma*0.1+ Sans * 0.2;

OrtaSaha sınıfı için

	PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2+ Dayaniklik * 0.1+   	        		      DogalForm * 0.1 + UzunTop*0.1 + TopSurmne*0.1+ Sans * 0.1;
           

Forvet sınıfı için

	PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 +		                DogalForm * 0.1 +  Sans * 0.1;

şeklinde oyuncunun özelliklerine göre hesaplanmalı 70 üzeri skor başarlı pas kabul 
edilmedlir.
 



GolVurusu metodunun tanımlı olduğu sınıflara göre başarılı olma durumu  

Futbolcu sınıfı için

	GolSkor =Yetenek * 0.3 + Sut*0.2+ Kararlik * 0.1 + DogalForm * 0.1+
	      	      Hiz *0.1+Sans*0.2;
        
Defans sınıfı için

	GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 +  			                Kafa * 0.1 + Sicarama*0.1+ Sans * 0.1;

OrtaSaha sınıfı için

          GolSkor = Yetenek * 0.3 + OzelYetenek*0.2+ Sut * 0.2 +Ilkdokunus*0.1+ 		 	                Kararlik * 0.1 + DogalForm * 0.1  + Sans * 0.1;
           
Forvet sınıfı için

  	GolSkor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 +Kafa*0.1+ Ilkdokunus * 0.1+ 		    Bitiricilik*0.1+SogukKanlilik*0.1+ Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

Şeklinde hesaplanarak 75 puanın üzerinde skor gol kabul edilmedilir.
